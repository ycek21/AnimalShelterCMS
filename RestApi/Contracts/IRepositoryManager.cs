using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        IAnimalRepository Animal { get; }
        IColorRepository Color { get; }
        IAnimalTypeRepository AnimalType { get; }
        ISizeRepository Size { get; }
        void Save();
        Task SaveAsync();
    }
}