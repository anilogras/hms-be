using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.SalesAndMarketing.OutOfEntities
{
    public class OutOf : BaseModel
    {
        public string Name { get; set; }
        public OutOfType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public OutOfSaleType SaleType { get; set; }

    }
}
