using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Core.Abstracts.Model;
using HMS.Core.Enums;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.MainModels.FrontOffice.ReservationModels;

namespace HMS.Entities.Models.MainModels.FrontOffice.FolioModels
{
    public class Folio : BaseModel
    {
        public FolioType Type { get; set; }
        public Guid ReservationDetailId{ get; set; }
        public int No { get; set; }
        public FolioStatus Status { get; set; }
        public Guid? InvoiceId { get; set; }
        public virtual ReservationDetail ReservationDetail { get; set; }
        [InverseProperty("Folio")]
        public virtual ICollection<FolioDetail> FolioDetails { get; set; }

        [InverseProperty("SourceFolio")]
        public virtual ICollection<FolioDetail> SourceFolioDetails { get; set; }

    }
}
