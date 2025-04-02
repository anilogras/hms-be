using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Core.Enums
{
    public enum TraceRequestType
    {
        Guest = 1,         // Misafir isteği
        Staff = 2,         // Otel personeli isteği
        Department = 3     // Bir departman tarafından bildirildi
    }
}
