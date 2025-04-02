using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Common.Contact
{
    public class State : BaseModel
    {
        public State()
        {
            Cities = new List<City>();
        }

        public string Name { get; set; }
        public Guid CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
