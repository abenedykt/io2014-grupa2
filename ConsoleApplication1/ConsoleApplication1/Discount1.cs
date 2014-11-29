using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Discount1 : IDiscount
    {
        private string _name;

        public string Name
        {
            get
            {
                return "discount1";
            }
            set { _name = Name; }
        }

        public double Discount
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
