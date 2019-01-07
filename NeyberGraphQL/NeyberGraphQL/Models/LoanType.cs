using GraphQL.Types;
using NeyberGraphQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeyberGraphQL.Models
{
    public class LoanType : ObjectGraphType<Loan>
    {
        public LoanType(IClientRepository clientRepository)
        {
            Field(x => x.Id).Description("Loan id.");
            Field(x => x.Name, nullable: true).Description("Loan name.");

            Field<ListGraphType<ClientType>>(
                "clients",
                resolve: context => clientRepository.GetClientsWithByLoanIdAsync(context.Source.Id).Result.ToList()
            );


        }
    }
}
