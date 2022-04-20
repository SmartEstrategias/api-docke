using System.Collections.Generic;
using System.Threading.Tasks;
using src.newDockeNet.Core.ChangeModelsView;
using src.newDockeNet.Core.Models;
using src.newDockeNet.Core.ModelsViewNew;

namespace src.newDockeNet.Manager.Managment
{
    public interface IUserManager
    {
        Task<IEnumerable<UserModel>> GetUsersAsync();
        Task<UserModel> GetUserByIdAsync(string id);
        Task<UserModel> InsertUserAsync(NewUserModel newUser);
        Task<UserModel> UpdateUserAsync(ChangeUserModel changeUser);
        Task<UserModel> DeleteUserAsync(string id);
    }
}