using AutoMapper;
using Domaine.Data;
using Domaine.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.MappingHelpers
{
    public class LeSiteMapping : Profile
    {
        public LeSiteMapping()
        {
            CreateMap<AccueilModel, AccueilModelDto>();
            CreateMap<AccueilModelDto, AccueilModel>();

            CreateMap<CategoryModel, CategoryModelDto>();
            CreateMap<CategoryModelDto, CategoryModel>();
        }
    }
}
