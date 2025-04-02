using HMS.Core.Abstracts.Dto;
using HMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.SalesAndMarketing
{
    public class ConditionDTO : BaseDto, IBaseDto
    {
        public DateTime AgreementDate { get; set; }
        public DateTime SaleDateStart { get; set; }
        public DateTime SaleDateEnd { get; set; }
        public DateTime StayDateStart { get; set; }
        public DateTime StayDateEnd { get; set; }
        public int MinDay { get; set; } = 0;
        public int MaxDay { get; set; } = 0;
        public ContractType Type { get; set; }

    }
}
