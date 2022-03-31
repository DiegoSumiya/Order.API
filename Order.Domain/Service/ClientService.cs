using Order.Domain.Interface.Services;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Service
{
    public class ClientService : IClientService
    {
        public Task CreateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClientModel>> GetByFiltersAsync(string clientId = null, string name = null)
        {
            throw new NotImplementedException();
        }

        public Task GetByIdAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }
    }
}
