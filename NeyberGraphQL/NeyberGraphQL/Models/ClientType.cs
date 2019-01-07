using GraphQL.Types;
using NeyberGraphQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeyberGraphQL.Models
{
    public class ClientType : ObjectGraphType<Client>
    {
        public ClientType(ILoanRepository loanRepository)
        {
            Field(x => x.Id).Description("Client id.");
            Field(x => x.FirstName).Description("First name.");
            Field(x => x.LastName).Description("Last name.");
            Field(x => x.Email).Description("Email.");

            Field<LoanType>(
                "loan",
                resolve: context => loanRepository.GetLoanAsync(context.Source.LoanId).Result
             );
        }
    }
}
