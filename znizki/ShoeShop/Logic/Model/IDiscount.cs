﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Model
{
    public interface IDiscount
    {
        double Calculate(IPosition position);
    }
}
