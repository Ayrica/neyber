using GraphQL.Types;
using NeyberGraphQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeyberGraphQL.Models
{
    public class EasyStoreQuery : ObjectGraphType
    {
        public EasyStoreQuery(ILoanRepository loanRepository, IClientRepository clientRepository)
        {
            Field<LoanType>(
                "loan",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Loan id" }
                ),
                resolve: context => loanRepository.GetLoanAsync(context.GetArgument<int>("id")).Result
            );

            Field<ClientType>(
                "client",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Client id" }
                ),
                resolve: context => clientRepository.GetClientAsync(context.GetArgument<int>("id")).Result
            );
        }
    }
}
