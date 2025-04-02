using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Core.Enums
{
    public enum TraceActionType
    {
        NewRecord = 1,          // Yeni
        Started = 2,            // Başladı
        Unresolved = 3,         // Çözülemedi
        WaitingForParts = 4,    // Parça bekliyor
        PartsArrived = 5,       // Parça geldi
        Replanned = 6,          // Tekrar planlandı
        Completed = 7,          // Tamamlandı
        Cancelled = 8,          // İptal edildi
        Assigned = 9            // Atama yapıldı
    }
}
