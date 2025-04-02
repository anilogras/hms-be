using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.SalesAndMarketing
{
    public class ContractDTO : BaseDto, IBaseDto, IBaseDefinition
    {
        public ICollection<ContractPeriodDTO>? Periods { get; set; }
        public ICollection<ContractAgencyDTO>? Agencys{ get; set; }
        public ICollection<PacketsDTO>? Packets { get; set; }
        public ConditionDTO? Condition { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
}
