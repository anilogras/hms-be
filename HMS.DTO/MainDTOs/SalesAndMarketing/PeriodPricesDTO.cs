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
    public class PeriodPricesDTO : BaseDto, IBaseDto
    {
        public ContractPeriodDTO ContractPeriod { get; set; }
        public Guid ContractPeriodId { get; set; }
        public Guid RoomLocationId { get; set; }
        public RoomLocationDTO RoomLocation { get; set; }
        public Guid PriceTypeId { get; set; }
        public PriceTypeDTO PriceType { get; set; }
        public double RawPrice { get; set; }
    }
}
