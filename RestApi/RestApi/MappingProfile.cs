using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace RestApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForCreationDto, User>()
                .ForMember(dest =>
                    dest.UserName,
                    opt => opt.MapFrom(src => src.Email));

            CreateMap<Animal, AnimalForAnimalListDto>()
                .ForMember(dest =>
                dest.Size,
                opt => opt.MapFrom(src => src.Size.Value))
                .ForMember(dest =>
                dest.Color,
                opt => opt.MapFrom(src => src.Color.Value))
                .ForMember(dest =>
                dest.AnimalType,
                opt => opt.MapFrom(src => src.AnimalType.Value));

            CreateMap<Animal, AnimalDto>()
                .ForMember(dest =>
                dest.Size,
                opt => opt.MapFrom(src => src.Size.Value))
                .ForMember(dest =>
                dest.Color,
                opt => opt.MapFrom(src => src.Color.Value))
                .ForMember(dest =>
                dest.AnimalType,
                opt => opt.MapFrom(src => src.AnimalType.Value));

            CreateMap<Walk, WalkForAnimalGet>();
        }

    }
}