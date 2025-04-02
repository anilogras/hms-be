using HMS.Core.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.DefinitionDTO.SalesAndMarketing.OutOfDTOs
{
    public class OutOfDTO : BaseDto
    {
        public string Name { get; set; }
        public OutOfType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public OutOfSaleType SaleType { get; set; }

    }
}
