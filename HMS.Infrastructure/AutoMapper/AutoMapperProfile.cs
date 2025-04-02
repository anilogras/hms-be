using AutoMapper;
using HMS.DTO.CommonDTOs;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models;
using HMS.Entities.Models.CommonModels;
using HMS.Entities.Models.Definition.FrontOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Enterprise, EnterpriseDto>().ReverseMap();
            CreateMap<Bank, BankDTO>().ReverseMap();
            CreateMap<BankDTO, Bank>().ReverseMap();
            CreateMap<Company,CompanyDto>().ReverseMap();
            CreateMap<Referance, ReferanceDto>().ReverseMap();
        }
    }
}
