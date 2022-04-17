using Order.Application.DataContract.Request;
using Order.Application.DataContract.Request.Client;
using Order.Application.DataContract.Response.Client;
using Order.Domain.Models;
using Order.Domain.Validations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.Interfaces
{
    public interface IClientApplication
    {
        Task<Response> CreateAsync(CreateClientRequest client);
        Task<Response> DeleteAsync(string clientId);
        Task<Response<ClientResponse>> GetByIdAsync(string clientId);
        Task<Response<List<ClientResponse>>> ListByFilterAsync(string clientId, string name);
        Task<Response> UpdateAsync(UpdateClientRequest request);
    }
}
