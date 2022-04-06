using Order.Domain.Models;
using Order.Domain.Validations.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Interface.Services
{
    public interface IClientService
    {
        Task<Response> CreateAsync(ClientModel client);
        Task<Response> UpdateAsync(ClientModel client);
        Task<Response> DeleteAsync(string clientId);
        Task<Response<ClientModel>> GetByIdAsync(string clientId);
        Task<Response<List<ClientModel>>>GetByFiltersAsync(string clientId = null, string name = null);
    }
}
