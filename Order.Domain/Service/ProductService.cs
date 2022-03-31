using Order.Domain.Interface.Services;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Service
{
    public class ProductService : IProductService
    {
        public Task CreateAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductModel>> GetByFiltersAsync(string productId = null, string description = null)
        {
            throw new NotImplementedException();
        }

        public Task GetByIdAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
