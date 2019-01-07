using NeyberGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeyberGraphQL.Data
{
    public interface ILoanRepository
    {
        Task<List<Loan>> LoansAsync();
        Task<Loan> GetLoanAsync(int id);
    }
}
