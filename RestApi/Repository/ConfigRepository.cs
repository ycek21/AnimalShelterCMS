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
    public class ConfigRepository : RepositoryBase<Config>, IConfigRepository
    {

        public ConfigRepository(RepositoryContext repositoryContext)
          : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Config>> GetAllConfigs(bool trackChanges)
        {
            return await FindAll(false).Include(c => c.User).ToListAsync();
        }

        public async Task<Config> GetConfigById(string ConfigId, bool trackChanges)
        {
            return await FindByCondition(c => c.Key == ConfigId, trackChanges).FirstOrDefaultAsync();
        }

    }
}