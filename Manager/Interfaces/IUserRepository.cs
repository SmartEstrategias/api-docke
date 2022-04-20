using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;

namespace newDockeNet.Manager.Interfaces
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