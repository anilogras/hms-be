using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Common.Contact
{
    public class Address : BaseModel
    {
        public Address()
        {
        }

        public City City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }
    }
}
