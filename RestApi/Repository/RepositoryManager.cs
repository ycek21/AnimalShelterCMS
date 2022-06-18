using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IUserRepository _userRepository;
        private IAnimalRepository _animalRepository;
        private IColorRepository _colorRepository;
        private ISizeRepository _sizeRepository;
        private IAnimalTypeRepository _animalTypeRepository;
        private IImageRepository _imageRepository;
        private IConfigRepository _configRepository;
        private IWalkRepository _walkRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IUserRepository User
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_repositoryContext);
                return _userRepository;
            }
        }

        public IAnimalRepository Animal
        {
            get
            {
                if (_animalRepository == null)
                    _animalRepository = new AnimalRepository(_repositoryContext);
                return _animalRepository;
            }
        }

        public IColorRepository Color
        {
            get
            {
                if (_colorRepository == null)
                    _colorRepository = new ColorRepository(_repositoryContext);
                return _colorRepository;
            }
        }
        public IAnimalTypeRepository AnimalType
        {
            get
            {
                if (_animalTypeRepository == null)
                    _animalTypeRepository = new AnimalTypeRepository(_repositoryContext);
                return _animalTypeRepository;
            }
        }
        public ISizeRepository Size
        {
            get
            {
                if (_sizeRepository == null)
                    _sizeRepository = new SizeRepository(_repositoryContext);
                return _sizeRepository;
            }
        }

        public IImageRepository Image
        {
            get
            {
                if (_imageRepository == null)
                    _imageRepository = new ImageRepository(_repositoryContext);
                return _imageRepository;
            }
        }

        public IConfigRepository Config
        {
            get
            {
                if (_configRepository == null)
                    _configRepository = new ConfigRepository(_repositoryContext);
                return _configRepository;
            }
        }

        public IWalkRepository Walk
        {
            get
            {
                if (_walkRepository == null)
                    _walkRepository = new WalkRepository(_repositoryContext);
                return _walkRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}