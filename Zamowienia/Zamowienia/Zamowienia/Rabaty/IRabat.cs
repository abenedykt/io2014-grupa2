﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamowienia;

namespace Zamowienia
{
    public interface IRabat
    {
        double ObliczRabatDlaZamowienia(Zamowienie order);

    }
}
