using HMS.Entities.Models.Base;
using HMS.Entities.Models.MainModels.FrontOffice.FolioModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.Models.Definition.FrontOffice
{
    public class Tax : BaseModelByNameCode
    {
        public double Rate { get; set; }

        [InverseProperty("Tax")]
        public virtual ICollection<TaxSequence> TaxSequences { get; set; }

        [InverseProperty("PrecedingTaxes")]
        public virtual ICollection<TaxSequence> PrecedingTaxes { get; set; }

    }
}
