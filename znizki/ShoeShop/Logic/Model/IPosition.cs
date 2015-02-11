using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Model
{
    public interface IPosition
    {
        IItem Item { get; set; }
        int Amount { get; set; }
        double Price { get; set; }
    }
}
