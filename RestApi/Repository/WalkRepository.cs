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
    public class WalkRepository : RepositoryBase<Walk>, IWalkRepository
    {
        public WalkRepository(RepositoryContext repositoryContext)
          : base(repositoryContext)
        {

        }

        public async Task<IEnumerable<Walk>> GetAnimalWalks(Guid AnimalId, bool trackChanges)
        {
            var walks = await FindByCondition(x => x.AnimalId == AnimalId, false).ToListAsync();

            return walks;
        }

        public void CreateWalk(Walk walk)
        {
            Create(walk);
        }

        public void DeleteWalk(Walk walk)
        {
            Delete(walk);
        }
    }
}