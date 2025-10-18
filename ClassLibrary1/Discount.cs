using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Discount
    {
        public string Name { get; set; }
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }
}
