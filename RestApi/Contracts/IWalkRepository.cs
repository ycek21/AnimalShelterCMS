using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IWalkRepository : IRepositoryBase<Walk>
    {
        Task<IEnumerable<Walk>> GetAnimalWalks(Guid AnimalId, bool trackChanges);

        void CreateWalk(Walk walk);

        void DeleteWalk(Walk Walk);
    }
}