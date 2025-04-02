using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;

namespace HMS.Entities.Models.MainModels.FrontOffice.FolioModels
{
    public class FolioDetail: EnBaseModel
    {
        public Guid FolioId { get; set; }
        public virtual Folio Folio{ get; set; }
        public Guid DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public Guid CurrencyId { get; set; }
        public virtual Currency Currency{ get; set; }
        public double Amount { get; set; }
        public double LocalAmount { get; set; }
        public double Rate { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public FolioDetailType Type { get; set; }
        public Guid TaxId { get; set; }
        public virtual Tax Tax { get; set; }
        public string? Remark { get; set; }
        public Guid SourceFolioId { get; set; }

        [ForeignKey("SourceFolioId")]
        public virtual Folio SourceFolio{ get; set; }
    }
}
