using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Common.Contact
{
    public class City : BaseModel
    {

        public City()
        {
        }

        public string Name { get; set; }
        public Guid StateId { get; set; }
        public virtual State State { get; set; }
    }
}
