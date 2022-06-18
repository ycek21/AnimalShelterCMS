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
    public class AnimalTypeRepository : RepositoryBase<AnimalType>, IAnimalTypeRepository
    {
        public AnimalTypeRepository(RepositoryContext repositoryContext)
         : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<AnimalType>> GetAllAnimalTypes(bool trackChanges)
        {
            var animalTypes = await FindAll(trackChanges).ToListAsync();

            return animalTypes;
        }
        public void CreateAnimalType(AnimalType animalType)
        {
            Create(animalType);
        }
    }
}