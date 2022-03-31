using Order.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Interface.Services
{
    public interface IProductService
    {
        Task CreateAsync(ProductModel product);
        Task UpdateAsync(ProductModel product);
        Task DeleteAsync(string productId);
        Task GetByIdAsync(string productId);
        Task<List<ProductModel>> GetByFiltersAsync(string productId = null, string description = null);
    }
}
