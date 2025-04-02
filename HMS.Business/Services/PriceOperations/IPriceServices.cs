using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Business.Services.PriceOperations
{
    public interface IPriceServices 
    {
        void FindContract();
        void FindPeriod();
        void FindPeriodPrices();
    }
}
