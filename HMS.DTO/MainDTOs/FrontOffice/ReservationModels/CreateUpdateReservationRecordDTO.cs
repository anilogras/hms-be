using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.FrontOffice.ReservationModels
{
    public class CreateUpdateReservationRecordDTO :BaseDto
    {

        public bool IsShare { get; set; }
        public bool IsGroup { get; set; }
        public string? GroupVoucher { get; set; }

    }
}
