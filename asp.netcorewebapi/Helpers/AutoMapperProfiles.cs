using asp.netcorewebapi.Dtos;
using asp.netcorewebapi.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.netcorewebapi.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City, CityForListDto>()
                .ForMember(dest => dest.PhotoUrl,opt =>{
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                });
            CreateMap<City, CityForDetailDto>();
        }
    }
}
