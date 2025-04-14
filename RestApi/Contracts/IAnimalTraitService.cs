using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DataTransferObjects;

namespace Contracts
{
    public interface IAnimalTraitService
    {
        Task<AnimalTraitDto> GetAnimalTraits();
    }
}