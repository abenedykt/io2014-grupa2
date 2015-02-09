using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamowienia.DAL.POCO.Orders.Status
{
    public class ProcessingStatus
    {
        public bool Accepted { get; set; }

        public bool Confirmed { get; set; }

        public bool Paid { get; set; }

    }


}
