using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeyberGraphQL.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public string Name { get; set; }

        List<Client> Clients { get; set; }
    }
}
