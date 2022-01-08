using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;

namespace Service
{
    public class AnimalTraitService : IAnimalTraitService
    {
        private IRepositoryManager _repository;
        private ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly IAuthenticationManager _authManager;

        public AnimalTraitService(ILoggerManager logger, IRepositoryManager repository, IMapper mapper, IAuthenticationManager authManager)
        {
            _repository = repository;
            _mapper = mapper;
            _authManager = authManager;
            _logger = logger;
        }

        public async Task<AnimalTraitDto> GetAnimalTraits()
        {
            var sizes = await _repository.Size.GetAllSizes(trackChanges: false);
            var colors = await _repository.Color.GetAllColors(trackChanges: false);
            var animalTypes = await _repository.AnimalType.GetAllAnimalTypes(trackChanges: false);

            var sizesDto = _mapper.Map<List<SizeDto>>(sizes);
            var colorsDto = _mapper.Map<List<ColorDto>>(colors);
            var animalTypesDto = _mapper.Map<List<AnimalTypeDto>>(animalTypes);

            AnimalTraitDto animalTraits = new AnimalTraitDto(sizesDto, colorsDto, animalTypesDto);

            return animalTraits;
        }
    }
}