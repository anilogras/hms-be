using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.FrontOffice
{
    public class Currency : BaseModelByNameCode
    {
        public Guid BankId { get; set; }
        public Bank Bank { get; set; }
    }
}
