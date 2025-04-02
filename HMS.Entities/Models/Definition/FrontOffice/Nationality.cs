using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.Common.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.FrontOffice
{
    public class Nationality : BaseModelByNameCode
    {
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
    }
}
