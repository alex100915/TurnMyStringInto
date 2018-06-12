using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TurnMyStringInto.Dtos;
using TurnMyStringInto.Models;

namespace TurnMyStringInto.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<TranslationDto, Translation>();
            Mapper.CreateMap<Translation, Translation>();
            Mapper.CreateMap<SuccessDto, Success>();
            Mapper.CreateMap<Success, SuccessDto>();
            Mapper.CreateMap<ContentsDto, Contents>();
            Mapper.CreateMap<Contents, ContentsDto>();
            Mapper.CreateMap<ErrorDto, Error>();
            Mapper.CreateMap<Error, ErrorDto>();
        }
    }
}