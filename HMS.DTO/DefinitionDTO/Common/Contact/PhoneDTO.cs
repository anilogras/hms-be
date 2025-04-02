using HMS.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.Common.Contact
{
    public class PhoneDTO : BaseDto
    {
        public PhoneDTO()
        {
        }
        public string PhoneNumber { get; set; }
    }
}
