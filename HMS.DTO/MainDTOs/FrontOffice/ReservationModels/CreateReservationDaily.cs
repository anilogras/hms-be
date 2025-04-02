using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.DTO.DefinitionDTO.FronOffice;

namespace HMS.DTO.MainDTOs.FrontOffice.ReservationModels
{
    public class CreateReservationDaily
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid? RoomId { get; set; }
        public Guid ReservationDetailId { get; set; }
        public int Pax { get; set; }
        public int Child { get; set; }
        public int Free { get; set; }
        public int Beb { get; set; }
    }
}
