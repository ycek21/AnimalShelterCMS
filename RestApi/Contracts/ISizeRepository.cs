using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface ISizeRepository : IRepositoryBase<Size>
    {
        Task<IEnumerable<Size>> GetAllSizes(bool trackChanges);

        void CreateSize(Size size);
    }
}