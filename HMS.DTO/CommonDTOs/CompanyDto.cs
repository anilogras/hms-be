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
    public class CompanyDto : BaseDto, IBaseDto, IBaseDefinition
    {
        public string Name { get; set; }
        public EnterpriseDto Enterprise { get; set; }
        public ICollection<ReferanceDto> Referances { get; set; }
        public string Code { get; set; }
    }
}
