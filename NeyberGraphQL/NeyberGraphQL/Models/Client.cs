using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeyberGraphQL.Models
{
    public class Client
    {
        public int Id { get; set; }
        public int LoanId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        Loan Loan { get; set; }
    }
}
