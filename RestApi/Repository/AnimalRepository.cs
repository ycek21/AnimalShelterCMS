using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AnimalRepository : RepositoryBase<Animal>, IAnimalRepository
    {
        public AnimalRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<Animal>> GetAllAnimalsWithFilterAsync(bool trackChanges, AnimalParameters animalParameters)
        {
            var animals = await FindAll(trackChanges).Include(a => a.Images.Where(i => i.IsProfilePicture == true))
                .Include(a => a.Size)
                .Include(a => a.Color)
                .Include(a => a.AnimalType)
                .Where(a => a.IsDead == false)
                .Where(a => animalParameters.Color == null ? true : animalParameters.Color.Contains(a.Color.Value))
                .Where(a => animalParameters.AnimalType == null ? true : animalParameters.AnimalType.Contains(a.AnimalType.Value))
                .Where(a => animalParameters.Size == null ? true : animalParameters.Size.Contains(a.Size.Value))
                .Where(a => animalParameters.Character == null ? true: animalParameters.Character.Contains(a.Character))
                .ToListAsync();

            return PagedList<Animal>.ToPagedList(animals, animalParameters.PageNumber, animalParameters.PageSize);
        }

        public async Task<Animal> GetAnimalById(Guid AnimalId, bool trackChanges)
        {
            return await FindByCondition(a => a.Id == AnimalId, false)
            .Include(a => a.Images)
            .Include(a => a.Walks)
            .Include(a => a.Size)
            .Include(a => a.Color)
            .Include(a => a.AnimalType)
            .FirstOrDefaultAsync();
        }

        public void CreateAnimal(Animal animal)
        {
            Create(animal);
        }
    }
}