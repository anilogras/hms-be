using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.DTO.DefinitionDTO.FronOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.SalesAndMarketing
{
    public class ContractAgencyDTO : BaseDto, IBaseDto
    {
        public AgencyDTO? Agency{ get; set; }
        public Guid? AgencyId{ get; set; }
        public Guid? ContractId{ get; set; }
        public ContractDTO? Contract{ get; set; }
    }
}
