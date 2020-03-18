using AutoMapper;
using DesignPatterns.Creational.Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class SandwichProfile : Profile
    {
        public SandwichProfile()
        {
            this.CreateMap<List<ApiResult>, List<Sandwich>>()
                .ReverseMap();
        }

    }
}
