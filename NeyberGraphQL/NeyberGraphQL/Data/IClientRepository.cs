using NeyberGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeyberGraphQL.Data
{
    public interface IClientRepository
    {
        Task<List<Client>> GetClientsAsync();
        Task<List<Client>> GetClientsWithByLoanIdAsync(int loanId);
        Task<Client> GetClientAsync(int id);
    }
}
