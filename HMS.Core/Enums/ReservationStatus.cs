using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Core.Enums
{
    public enum ReservationStatus
    {
        Confirmed = 0,
        CheckIn = 1,
        CheckOut = 2,
        Pending = 3,
        NotConfirmed =4,
        Cancel = 5,
    }
}
