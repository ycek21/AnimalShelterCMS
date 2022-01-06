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

        public async Task<PagedList<Animal>> GetAllAnimalsAsync(bool trackChanges, AnimalParameters animalParameters)
        {
            var animals = await FindAll(false).Include(a => a.Images.Where(i => i.IsProfilePicture == true))
                .Include(a => a.Size)
                .Include(a => a.Color)
                .Include(a => a.AnimalType)
                .Where(a => a.IsDead == false)
                .OrderBy(e => e.Name)
                .ToListAsync();

            return PagedList<Animal>.ToPagedList(animals, animalParameters.PageNumber, animalParameters.PageSize);
        }
    }
}