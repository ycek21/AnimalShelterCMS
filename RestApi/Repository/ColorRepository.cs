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
    public class ColorRepository : RepositoryBase<Color>, IColorRepository
    {
        public ColorRepository(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Color>> GetAllColors(bool trackChanges)
        {
            var colors = await FindAll(trackChanges).ToListAsync();

            return colors;
        }
    }
}