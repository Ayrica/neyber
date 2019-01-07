using NeyberGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeyberGraphQL.Data
{
    public class LoanRepository : ILoanRepository
    {
        private List<Loan> _loans;

        public LoanRepository()
        {
            _loans = new List<Loan>{
                new Loan()
                {
                    Id = 1,
                    Name = "Wedding"
                },
                new Loan()
                {
                    Id = 2,
                    Name = "Car"
                },
                new Loan()
                {
                    Id = 3,
                    Name = "Flat"
                }
            };
        }

        public Task<List<Loan>> LoansAsync()
        {
            return Task.FromResult(_loans);
        }

        public Task<Loan> GetLoanAsync(int id)
        {
            return Task.FromResult(_loans.FirstOrDefault(x => x.Id == id));
        }
    }
}
