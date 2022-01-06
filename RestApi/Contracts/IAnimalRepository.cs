using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IAnimalRepository : IRepositoryBase<Animal>
    {
        Task<IEnumerable<Animal>> GetAllAnimalsAsync(bool trackChanges);
    }
}