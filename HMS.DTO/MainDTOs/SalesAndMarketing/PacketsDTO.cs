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
    public class PacketsDTO : BaseDto, IBaseDto
    {
        public Guid ContractId { get; set; }
        public ContractDTO? Contract { get; set; }
        public Guid ConditionId { get; set; }
        public ConditionDTO Condition { get; set; }
        public Guid PacketTypeId { get; set; }
        public PacketTypeDTO? PacketType { get; set; }
        public int? Ratio { get; set; }
        public double? Price { get; set; } // Yüzdelik indirim olmayabilir sabit tutar indirimi olabilir program ayarlanırken ratio boşsa price dolu olmak zorunda price boşsa ratio dolu olmak zorunda
        public Guid? AgencyId { get; set; } // Acente'ye özel paket girildiğinde burası dolu olmak zorunda
        public AgencyDTO? Agency{ get; set; }

    }
}
