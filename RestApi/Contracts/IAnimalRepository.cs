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
        Task<Animal> GetAnimalById(Guid AnimalId, bool trackChanges);
        Task<PagedList<Animal>> GetAllAnimalsWithFilterAsync(bool trackChanges, AnimalParameters animalParameters);
        void CreateAnimal(Animal animal);

    }
}