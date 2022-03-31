using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Interface.Repository
{
    public interface IOrderRepository
    {
        Task CreateAsync(OrderModel order);
        Task CreateAsync(OrderItemModel orderItem);
        Task UpdateAsync(OrderModel order);
        Task UpdateAsync(OrderItemModel orderItem);
        Task DeleteAsync(string orderId);
        Task DeleteIetmAsync(string orderItemId);
        Task<bool> ExistByIdAsync(string orderId);
        Task<OrderModel> GetByIdAsync(string orderId);
        Task<List<OrderModel>> ListByFilterAsync(string orderId = null, string clientId = null, string userId = null);
        Task<List<OrderItemModel>> ListItemsByFilterAsync(string orderId = null);
    }
}
