﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamowienia.DAL.POCO.Orders.Status
{
    public class OrderStatus
    {
        public ProcessingStatus ProcesStatus { get; set; }

        public DeliveryStatus DeliveryStatus { get; set; }

    }


}
