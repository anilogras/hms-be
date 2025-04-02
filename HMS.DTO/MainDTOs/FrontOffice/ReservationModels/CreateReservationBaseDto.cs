using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DTO.MainDTOs.FrontOffice.ReservationModels
{
    public class CreateReservationBaseDto
    {
        public CreateUpdateReservationRecordDTO record { get; set; }
        public List<CreateUpdateReservationDTO> details { get; set; }
    }
}
