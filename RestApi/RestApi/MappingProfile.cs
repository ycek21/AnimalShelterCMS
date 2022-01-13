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

            CreateMap<User, UserDto>();

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

            CreateMap<Walk, WalkForAnimalGetDto>();
            CreateMap<Size, Animal>();
            CreateMap<AnimalForCreationDto, Animal>();
            CreateMap<Size, SizeDto>();
            CreateMap<Color, ColorDto>();
            CreateMap<AnimalType, AnimalTypeDto>();
            CreateMap<ImageForCreationDto, Image>();
            CreateMap<Config, ConfigDto>().ForMember(
                dest => dest.ModifiedBy,
                opt => opt.MapFrom(src => src.User.Email)
            );
        }
    }
}