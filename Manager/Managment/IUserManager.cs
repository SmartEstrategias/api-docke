using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;

namespace newDockeNet.Manager.Managment
{
    public interface IUserManager
    {
        Task<IEnumerable<UserModel>> GetUsersAsync();
        Task<UserModel> GetUserByIdAsync(int id);
        Task<UserModel> InsertUserAsync(NewUserModel newUser);
        Task<UserModel> UpdateUserAsync(ChangeUserModel changeUser);
        Task<UserModel> DeleteUserAsync(int id);
    }
}