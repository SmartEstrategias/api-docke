using System.Collections.Generic;
using System.Threading.Tasks;
using src.newDockeNet.Core.Models;

namespace src.newDockeNet.Manager.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserModel>> GetUsersAsync();
        Task<UserModel> GetUserByIdAsync(string id);
        Task<UserModel> InsertUserAsync(UserModel user);
        Task<UserModel> UpdateUserAsync(UserModel user);
        Task<UserModel> DeleteUserAsync(string id);
    }
}