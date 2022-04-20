using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using src.newDockeNet.Core.ChangeModelsView;
using src.newDockeNet.Core.Models;
using src.newDockeNet.Core.ModelsViewNew;
using src.newDockeNet.Manager.Interfaces;
using src.newDockeNet.Manager.Managment;

namespace src.newDockeNet.Manager.Implementations
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        public UserManager(IUserRepository userRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public async Task<IEnumerable<UserModel>> GetUsersAsync()
        {
            return await userRepository.GetUsersAsync();
        }
        public async Task<UserModel> GetUserByIdAsync(string id)
        {
            return await userRepository.GetUserByIdAsync(id);
        }
        public async Task<UserModel> InsertUserAsync(NewUserModel newUser)
        {
            var user = mapper.Map<UserModel>(newUser);
            return await userRepository.InsertUserAsync(user);
        }
        public async Task<UserModel> UpdateUserAsync(ChangeUserModel changeUser)
        {
            var user = mapper.Map<UserModel>(changeUser);
            return await userRepository.UpdateUserAsync(user);
        }
        public async Task<UserModel> DeleteUserAsync(string id)
        {
            return await userRepository.DeleteUserAsync(id);
        }
    }
}