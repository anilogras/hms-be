using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Entities.Models.Base;

namespace HMS.Entities.Models.Definition.FrontOffice
{
    public class TaxSequence :EnBaseModel
    {
        public Guid TaxId { get; set; }
        public Guid PrecedingTax { get; set; }
        public virtual Tax Tax { get; set; }
        [ForeignKey("PrecedingTax")]
        public virtual Tax PrecedingTaxes { get; set; }
        public int Order { get; set; }
    }
}
