using Order.Domain.Interface.Repository;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infra.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Task CreateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistByIdAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<ClientModel> GetByIdAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClientModel>> ListByFilterAsync(string clientId = null, string name = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }
    }
}
