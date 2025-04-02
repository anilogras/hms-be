using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.FrontOffice
{
    public class HKCode : BaseModelByNameCode
    {
        public string Color { get; set; }
        public HKCodeType CleanCode { get; set; }
    }
}
