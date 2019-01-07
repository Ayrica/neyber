using NeyberGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeyberGraphQL.Data
{
    public class ClientRepository : IClientRepository
    {
        private List<Client> _clients;

        public ClientRepository()
        {
            _clients = new List<Client>{
                new Client(){Id = 0, LoanId = 2, FirstName = "Sergey", LastName = "Gurbich", Email = "klukovka.julia@mail.ru"},
                new Client(){Id = 1, LoanId = 1, FirstName = "Vitia", LastName = "Kremen", Email = "matrena.ivanovna@gmail.com"},
                new Client(){Id = 2, LoanId = 1, FirstName = "Liza", LastName = "Bedrosov", Email = "nosenko.alena@sparkybit.co.ua"},
                new Client(){Id = 3, LoanId = 3, FirstName = "Dima", LastName = "Kremen", Email = "gonchar.evgen@gmail.com"},
                new Client(){Id = 4, LoanId = 1, FirstName = "Vitia", LastName = "Gurbich", Email = "matrena.ivanovna@gmail.com"},
                new Client(){Id = 5, LoanId = 3, FirstName = "Liza", LastName = "Fintechband", Email = "klukovka.julia@mail.ru"},
                new Client(){Id = 6, LoanId = 3, FirstName = "Alex", LastName = "Bedrosov", Email = "nikita.dobrinich@ua.fm"},
                new Client(){Id = 7, LoanId = 2, FirstName = "Silva", LastName = "Kremen", Email = "nikita.dobrinich@ua.fm"},
                new Client(){Id = 8, LoanId = 1, FirstName = "Liza", LastName = "Gdanov", Email = "matrena.ivanovna@gmail.com"},
                new Client(){Id = 9, LoanId = 3, FirstName = "Alex", LastName = "Klukov", Email = "nikita.dobrinich@ua.fm"},
                new Client(){Id = 10, LoanId = 3, FirstName = "Stiven", LastName = "Fintechband", Email = "nosenko.alena@sparkybit.co.ua"},
                new Client(){Id = 11, LoanId = 2, FirstName = "Vitia", LastName = "Filipok", Email = "klukovka.julia@mail.ru"},
                new Client(){Id = 12, LoanId = 2, FirstName = "Sandra", LastName = "Klukov", Email = "matrena.ivanovna@gmail.com"},
                new Client(){Id = 13, LoanId = 1, FirstName = "Alex", LastName = "Stetch", Email = "gonchar.evgen@gmail.com"},
                new Client(){Id = 14, LoanId = 1, FirstName = "Olena", LastName = "Stetch", Email = "klukovka.julia@mail.ru"},
                new Client(){Id = 15, LoanId = 3, FirstName = "Dima", LastName = "Kremen", Email = "nikita.dobrinich@ua.fm"},
                new Client(){Id = 16, LoanId = 3, FirstName = "Nikita", LastName = "Gukov", Email = "gonchar.evgen@gmail.com"},
                new Client(){Id = 17, LoanId = 2, FirstName = "Liza", LastName = "Klukov", Email = "nosenko.alena@sparkybit.co.ua"},
                new Client(){Id = 18, LoanId = 1, FirstName = "Dzintra", LastName = "Gukov", Email = "nikita.dobrinich@ua.fm"},
                new Client(){Id = 19, LoanId = 3, FirstName = "Silva", LastName = "Klukov", Email = "matrena.ivanovna@gmail.com"},
                new Client(){Id = 20, LoanId = 3, FirstName = "Dzintra", LastName = "Bedrosov", Email = "matrena.ivanovna@gmail.com"},
                new Client(){Id = 21, LoanId = 2, FirstName = "Sergey", LastName = "Bedrosov", Email = "nikita.dobrinich@ua.fm"},
                new Client(){Id = 22, LoanId = 2, FirstName = "Sandra", LastName = "Petrosan", Email = "nosenko.alena@sparkybit.co.ua"},
                new Client(){Id = 23, LoanId = 1, FirstName = "Silva", LastName = "Scrudg", Email = "gonchar.evgen@gmail.com"},
                new Client(){Id = 24, LoanId = 1, FirstName = "Olena", LastName = "Scrudg", Email = "nikita.dobrinich@ua.fm"},
                new Client(){Id = 25, LoanId = 3, FirstName = "Liza", LastName = "Bedrosov", Email = "klukovka.julia@mail.ru"},
                new Client(){Id = 26, LoanId = 3, FirstName = "Vasyl", LastName = "Petrosan", Email = "gonchar.evgen@gmail.com"},
                new Client(){Id = 27, LoanId = 2, FirstName = "Dima", LastName = "Petrosan", Email = "matrena.ivanovna@gmail.com"},
                new Client(){Id = 28, LoanId = 1, FirstName = "Stiven", LastName = "Petrosan", Email = "klukovka.julia@mail.ru"},
                new Client(){Id = 29, LoanId = 3, FirstName = "Alex", LastName = "Petrosan", Email = "nosenko.alena@sparkybit.co.ua"},
                new Client(){Id = 30, LoanId = 2, FirstName = "Dzintra", LastName = "Kremen", Email = "klukovka.julia@mail.ru"},
                new Client(){Id = 31, LoanId = 1, FirstName = "Silva", LastName = "Stetch", Email = "nikita.dobrinich@ua.fm"},
                new Client(){Id = 32, LoanId = 1, FirstName = "Vasyl", LastName = "Filipok", Email = "gonchar.evgen@gmail.com"},
                new Client(){Id = 33, LoanId = 3, FirstName = "Sergey", LastName = "Fintechband", Email = "nosenko.alena@sparkybit.co.ua"},
                new Client(){Id = 34, LoanId = 3, FirstName = "Stiven", LastName = "Filipok", Email = "nikita.dobrinich@ua.fm"},
                new Client(){Id = 35, LoanId = 2, FirstName = "Vitia", LastName = "Kremen", Email = "matrena.ivanovna@gmail.com"},
                new Client(){Id = 36, LoanId = 2, FirstName = "Sandra", LastName = "Klukov", Email = "nosenko.alena@sparkybit.co.ua"},
                new Client(){Id = 37, LoanId = 1, FirstName = "Alex", LastName = "Gukov", Email = "klukovka.julia@mail.ru"},
                new Client(){Id = 38, LoanId = 3, FirstName = "Olena", LastName = "Gukov", Email = "matrena.ivanovna@gmail.com"},
                new Client(){Id = 39, LoanId = 2, FirstName = "Dima", LastName = "Filipok", Email = "gonchar.evgen@gmail.com"},
                new Client(){Id = 40, LoanId = 3, FirstName = "Dzintra", LastName = "Ivanov", Email = "klukovka.julia@mail.ru"},
                new Client(){Id = 41, LoanId = 2, FirstName = "Sergey", LastName = "Gdanov", Email = "nosenko.alena@sparkybit.co.ua"},
                new Client(){Id = 42, LoanId = 2, FirstName = "Sandra", LastName = "Gurbich", Email = "matrena.ivanovna@gmail.com"},
                new Client(){Id = 43, LoanId = 1, FirstName = "Silva", LastName = "Gurbich", Email = "nikita.dobrinich@ua.fm"},
                new Client(){Id = 44, LoanId = 1, FirstName = "Olena", LastName = "Gurbich", Email = "nosenko.alena@sparkybit.co.ua"},
                new Client(){Id = 45, LoanId = 3, FirstName = "Liza", LastName = "Gurbich", Email = "gonchar.evgen@gmail.com"},
                new Client(){Id = 46, LoanId = 3, FirstName = "Vasyl", LastName = "Gdanov", Email = "nikita.dobrinich@ua.fm"},
                new Client(){Id = 47, LoanId = 2, FirstName = "Dima", LastName = "Ivanov", Email = "klukovka.julia@mail.ru"},
                new Client(){Id = 48, LoanId = 1, FirstName = "Stiven", LastName = "Gdanov", Email = "gonchar.evgen@gmail.com"},
                new Client(){Id = 49, LoanId = 3, FirstName = "Alex", LastName = "Gurbich", Email = "matrena.ivanovna@gmail.com"}
            };
        }

        public Task<Client> GetClientAsync(int id)
        {
            return Task.FromResult(_clients.FirstOrDefault(x => x.Id == id));
        }

        public Task<List<Client>> GetClientsAsync()
        {
            return Task.FromResult(_clients);
        }

        public Task<List<Client>> GetClientsWithByLoanIdAsync(int loanId)
        {
            return Task.FromResult(_clients.Where(x => x.LoanId == loanId).ToList());
        }
    }
}
