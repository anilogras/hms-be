using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.FrontOffice
{
    public class Department : BaseModelByNameCode
    {
        public Guid TaxId { get; set; }
        public Tax Tax { get; set; }
        public DepartmanType Type { get; set; }
    }
}
