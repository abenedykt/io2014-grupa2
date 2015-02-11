using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Model
{
    public class Shoe : IItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
