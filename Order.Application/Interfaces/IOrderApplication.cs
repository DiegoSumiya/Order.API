using Order.Application.DataContract.Request.Order;
using Order.Application.DataContract.Response.Order;
using Order.Domain.Validations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.Interfaces
{
    public interface IOrderApplication
    {
        Task<Response> CreateAsync(CreateOrderRequest Order);
        Task<Response<List<OrderResponse>>> ListByFilterAsync(string orderId = null, string clientId = null, string userId = null);
        Task<Response<OrderResponse>> GetByIdAsync(string orderId);
    }
}
