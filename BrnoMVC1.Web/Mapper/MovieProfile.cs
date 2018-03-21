using AutoMapper;
using BrnoMVC1.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrnoMVC1.Web.Mapper
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            this.CreateMap<Movie, MovieViewModel>().ReverseMap(); // Reverse - umi i obracene

            this.CreateMap<Movie, MovieViewModel>()
                .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title + " - nej film"));

        }
    }
}