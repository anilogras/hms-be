using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Core.Enums
{
    public enum TraceStatus
    {
        Opened = 1,           // İş açıldı
        Planned = 2,          // Planlandı
        Read = 3,             // Okundu
        WaitingForParts = 4,  // Parça bekliyor
        PartsArrived = 5,     // Parça geldi
        Replanned = 6,        // Tekrar planlandı
        Completed = 7,        // Tamamlandı
        Cancelled = 8         // İptal edildi
    }
}
