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
    public class SizeRepository : RepositoryBase<Size>, ISizeRepository
    {
        public SizeRepository(RepositoryContext repositoryContext)
          : base(repositoryContext)
        {

        }

        public async Task<IEnumerable<Size>> GetAllSizes(bool trackChanges)
        {
            var sizes = await FindAll(trackChanges).ToListAsync();

            return sizes;
        }
        
        public void CreateSize(Size size)
        {
            Create(size);
        }
    }
}