using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Core.Abstracts.Model;
using HMS.Entities.Models.Base;

namespace HMS.Entities.Models.Definition.FrontOffice
{
    public class Rate : EnBaseModel,IBaseModel
    {
        public Guid BankId { get; set; }
        public Guid CurrencyId { get; set; }
        public DateTime Date { get; set; }
        public double RateAmount { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual Currency Currency { get; set; }
    }
}
