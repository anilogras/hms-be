using HMS.DTO.DefinitionDTO.FronOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.FrontOffice.ReservationModels
{
    public class ReservationRecordDTO : BaseDto
    {
        public ReservationRecordDTO()
        {
            ReservationDetails = new List<ReservationDetailDTO>();
        }


        public string GroupVoucher { get; set; }

        public bool IsShare { get; set; }
        public bool IsGroup { get; set; }
        public virtual ICollection<ReservationDetailDTO> ReservationDetails { get; set; }

    }
}
