using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamowienia.BLS.Services.Management
{
    static public class DiscountManagementService
    {
        static public int GetPriorityForDiscount(IDiscount disc)
        {
            return 1;
        }
    }

}
