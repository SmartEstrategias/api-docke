using Microsoft.EntityFrameworkCore;
using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;
using newDockeNet.Data.Context;
using newDockeNet.Manager.Interfaces;

namespace newDockeNet.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DockeContext context;
        public UserRepository(DockeContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<UserModel>> GetUsersAsync()
        {
            return await context.Users.AsNoTracking().ToListAsync();
        }

        public async Task<UserModel> GetUserByIdAsync(string id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<UserModel> InsertUserAsync(UserModel user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<UserModel> UpdateUserAsync(UserModel user)
        {
            var updatedUser = await context.Users.FindAsync(user.UserId);

            if (updatedUser == null) return null;

            context.Entry(updatedUser).CurrentValues.SetValues(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<UserModel> DeleteUserAsync(string id)
        {
            var deletedUser = await context.Users.FindAsync(id);

            if (deletedUser == null) return null;

            context.Users.Remove(deletedUser);
            await context.SaveChangesAsync();
            return deletedUser;
        }
    }
}