using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.Common.Contact
{
    public class Email : BaseModel
    {
        public Email()
        {
        }
        public string EmailAddress { get; set; }
    }
}
