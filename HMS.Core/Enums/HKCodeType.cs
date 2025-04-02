using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Core.Enums
{
    public enum HKCodeType
    {
        EmptyClear = 0,
        EmptyDirty = 1,
        FilledClean = 2,
        FilledDirty = 3,
        Touch = 4,
        DND = 5,
        SleepOut = 6,
    }
}
