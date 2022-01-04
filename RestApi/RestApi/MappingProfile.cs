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
        }
    }
}