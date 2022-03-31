using Order.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Interface.Services
{
    public interface IClientService
    {
        Task CreateAsync(ClientModel client);
        Task UpdateAsync(ClientModel client);
        Task DeleteAsync(string clientId);
        Task GetByIdAsync(string clientId);
        Task <List<ClientModel>>GetByFiltersAsync(string clientId = null, string name = null);
    }
}
