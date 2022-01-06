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
    public class AnimalRepository : RepositoryBase<Animal>, IAnimalRepository
    {
        public AnimalRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Animal>> GetAllAnimalsAsync(bool trackChanges)
        {
            return await FindAll(false).Include(a => a.Images.Where(i => i.IsProfilePicture == true))
                .Include(a => a.Size)
                .Include(a => a.Color)
                .Include(a => a.AnimalType)
                .Where(a => a.IsDead == false)
                .ToListAsync();
        }
    }
}