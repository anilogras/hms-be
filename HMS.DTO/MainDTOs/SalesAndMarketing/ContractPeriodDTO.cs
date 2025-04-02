using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.SalesAndMarketing
{
    public class ContractPeriodDTO : BaseDto, IBaseDto
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Guid? ContractId { get; set; }
        public ContractDTO? Contract { get; set; }
    }
}
