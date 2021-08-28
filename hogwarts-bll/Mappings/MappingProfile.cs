using System.Collections.Generic;
using AutoMapper;
using hogwarts_bll.Models;
using hogwarts_bll.Models.Dto;
using hogwarts_bll.Models.Request;
using hogwarts_repository.Models;

namespace hogwarts_bll.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HouseModel, House>();
            CreateMap<UpdateHouse, House>();
            CreateMap<NewHouse, House>();

            CreateMap<House, HouseModel>();
            CreateMap<House, NewHouse>();
            CreateMap<House, UpdateHouse>();
        }
    }
}