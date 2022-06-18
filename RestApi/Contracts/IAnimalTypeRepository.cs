using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IAnimalTypeRepository : IRepositoryBase<AnimalType>
    {
        Task<IEnumerable<AnimalType>> GetAllAnimalTypes(bool trackChanges);

        void CreateAnimalType(AnimalType animalType);
    }
}