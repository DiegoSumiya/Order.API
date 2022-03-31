using Order.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Interface.Services
{
    public interface IUserService
    {
        Task <bool>AuthenticationAsync(UserModel user);
        Task CreateAsync(UserModel user);
        Task UpdateAsync(UserModel user);
        Task DeleteAsync(string userId);
        Task GetByIdAsync(string userId);
        Task<List<UserModel>> GetByFiltersAsync(string userId = null, string name = null);
    }
}
