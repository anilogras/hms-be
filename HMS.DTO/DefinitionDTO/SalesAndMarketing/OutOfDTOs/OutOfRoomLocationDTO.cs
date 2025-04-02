
using HMS.DTO.DefinitionDTO.FronOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.SalesAndMarketing.OutOfDTOs
{
    public class OutOfRoomLocationDTO : BaseDto
    {
        public Guid OutOfId { get; set; }
        public OutOfDTO OutOf { get; set; }

        public Guid RoomLocationId { get; set; }
        public RoomLocationDTO RoomLocation { get; set; }



    }
}
