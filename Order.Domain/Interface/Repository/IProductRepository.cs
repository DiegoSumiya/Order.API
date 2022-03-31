using Order.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Interface.Repository
{
    public interface IProductRepository
    {
        Task CreateAsync(ProductModel product);
        Task UpdateAsync(ProductModel product);
        Task DeleteAsync(string productId);
        Task<bool> ExistByIdAsync(string productId);
        Task<ProductModel> GetByIdAsync(string productId);
        Task<List<ProductModel>> ListByFilterAsync(string productId = null, string description = null);
    }
}
