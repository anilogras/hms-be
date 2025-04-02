using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.Common.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Common
{
    public  class Person : BaseModel
    {
        /// <summary>
        /// base class tablosu açılmayacak
        /// </summary>

        public Person()
        {
            Phones = new List<Phone>(); 
            Emails = new List<Email>();
            Addresses = new List<Address>();
        }

        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderType Gender { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
