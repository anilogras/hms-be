using HMS.Core.Enums;
using HMS.Dto.Base;
using HMS.DTO.DefinitionDTO.Common.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.Common
{
    public  class PersonDTO : BaseDto
    {
        /// <summary>
        /// base class tablosu açılmayacak
        /// </summary>

        public PersonDTO()
        {
            Phones = new List<PhoneDTO>(); 
            Emails = new List<EmailDTO>();
            Addresses = new List<AddressDTO>();
        }

        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderType Gender { get; set; }
        public virtual ICollection<PhoneDTO> Phones { get; set; }
        public virtual ICollection<EmailDTO> Emails { get; set; }
        public virtual ICollection<AddressDTO> Addresses { get; set; }
    }
}
