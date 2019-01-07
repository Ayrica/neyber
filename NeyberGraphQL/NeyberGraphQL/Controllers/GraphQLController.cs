using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeyberGraphQL.Data;
using NeyberGraphQL.Models;

namespace NeyberGraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphQLController : ControllerBase
    {
        private readonly IDocumentExecuter _documentExecuter;
        private readonly ISchema _schema;
        private readonly IClientRepository _clientRepository;

        public GraphQLController(IDocumentExecuter documentExecuter, ISchema schema, IClientRepository clientRepository)
        {
            _documentExecuter = documentExecuter;
            _schema = schema;
            _clientRepository = clientRepository;
        }

        [HttpPost]
        [Route("graphql/getloans")]
        public async Task<IActionResult> Post([FromBody]GraphQLQuery query)
        {
            if (query == null) { throw new ArgumentNullException(nameof(query)); }

            var executionOptions = new ExecutionOptions { Schema = _schema, Query = query.Query };

            try
            {
                var result = await _documentExecuter.ExecuteAsync(executionOptions).ConfigureAwait(false);

                if (result.Errors?.Count > 0)
                {
                    return BadRequest(result);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("graphql/getclients")]
        public async Task <List<Client>> GetAllClient()
        {
            return await _clientRepository.GetClientsAsync();
        }
    }
}