using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.SalesAndMarketing.OutOfEntities
{
    public class OutOfRoom : BaseModel
    {
        public Guid OutOfId { get; set; }
        public OutOf OutOf { get; set; }

        public Guid RoomId { get; set; }
        public Room Room { get; set; }



    }
}
