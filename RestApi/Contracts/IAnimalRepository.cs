using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Entities.RequestFeatures;

namespace Contracts
{
    public interface IAnimalRepository : IRepositoryBase<Animal>
    {
        Task<PagedList<Animal>> GetAllAnimalsAsync(bool trackChanges, AnimalParameters animalParameters);
    }
}