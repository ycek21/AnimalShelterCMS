using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);
        Task<User> GetUserAsync(string userId, bool trackChanges);
        void CreateUser(User owner);
        void UpdateUser(User owner);
        void DeleteUser(User owner);
    }
}