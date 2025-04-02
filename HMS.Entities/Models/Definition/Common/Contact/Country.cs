using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Common.Contact
{
    public class Country : BaseModel
    {
        public Country()
        {
            States = new List<State>();
        }
        public string IsoCode { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}
