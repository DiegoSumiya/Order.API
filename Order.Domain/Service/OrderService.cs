using Order.Domain.Interface.Services;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Service
{
    public class OrderService : IOrderService
    {
        public Task CreateAsync(OrderModel order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderModel>> GetByFiltersAsync(string orderId = null, string clientId = null, string userId = null)
        {
            throw new NotImplementedException();
        }

        public Task GetByIdAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(OrderModel order)
        {
            throw new NotImplementedException();
        }
    }
}
