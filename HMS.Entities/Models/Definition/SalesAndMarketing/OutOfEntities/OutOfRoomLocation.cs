using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.SalesAndMarketing.OutOfEntities
{
    public class OutOfRoomLocation : BaseModel
    {
        public Guid OutOfId { get; set; }
        public OutOf OutOf { get; set; }

        public Guid RoomLocationId { get; set; }
        public RoomLocation RoomLocation { get; set; }



    }
}
