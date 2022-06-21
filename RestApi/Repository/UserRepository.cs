using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges)
        {
            return await FindAll(false).OrderBy(o => o.Email).ToListAsync();
        }

        public async Task<User> GetUserAsync(string userId, bool trackChanges)
        {
            return await FindByCondition(u => u.Id.Equals(userId), trackChanges)
            .SingleOrDefaultAsync();
        }

        public async Task<User> GetUserWithWalksAsync(string userId, bool trackChanges)
        {
            return await FindByCondition(u => u.Id.Equals(userId), trackChanges).Include(x => x.Walks)
            .SingleOrDefaultAsync();
        }

        public void CreateUser(User user)
        {
            Create(user);
        }
        public void UpdateUser(User user)
        {
            Update(user);
        }
        public void DeleteUser(User user)
        {
            Delete(user);
        }
    }
}