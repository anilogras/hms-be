using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.CommonDTOs
{
    public class ReferanceDto : BaseDto, IBaseDto, IBaseDefinition
    {
        public string Name { get; set; }
        public CompanyDto Company { get; set; }
        public string Code { get; set; }


    }
}
