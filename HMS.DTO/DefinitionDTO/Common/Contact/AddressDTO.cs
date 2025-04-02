using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.Common.Contact
{
    public class AddressDTO : BaseDto
    {
        public AddressDTO()
        {
        }

        public CityDTO City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public CountryDTO Country { get; set; }
    }
}
