using HMS.Core.Abstracts.Dto;
using HMS.Core.Abstracts.Model;
using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.FronOffice
{
    public class RoomDTO : BaseDto, IBaseDto, IBaseDefinition
    {
        public Guid RoomLocationId { get; set; }
        public RoomLocationDTO RoomLocation { get; set; }
        public Guid FloorId { get; set; }
        public FloorDTO Floor { get; set; }
        public Guid HKCodeId { get; set; }
        public HKCodeDTO HKCode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
