using Order.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Interface.Services
{
    public interface IOrderService
    {
        Task CreateAsync(OrderModel order);
        Task UpdateAsync(OrderModel order);
        Task DeleteAsync(string orderId);
        Task GetByIdAsync(string orderId);
        Task<List<OrderModel>> GetByFiltersAsync(string orderId = null, string clientId = null, string userId = null);
    }
}
