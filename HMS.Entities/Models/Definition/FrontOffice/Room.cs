
using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.FrontOffice
{
    public class Room : BaseModelByNameCode
    {
        public Guid RoomLocationId { get; set; }
        public RoomLocation RoomLocation { get; set; }
        public Guid FloorId { get; set; }
        public Floor Floor { get; set; }
        public Guid HKCodeId { get; set; }
        public HKCode HKCode { get; set; }
    }
}
