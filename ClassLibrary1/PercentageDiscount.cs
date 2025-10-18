using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PercentageDiscount : Discount
    {
        private decimal percentage;
        public PercentageDiscount(decimal percent)
        {
            Name = "Percentage Discount";
            percentage = percent;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
            => price * quantity * (percentage / 100);
    }
    public class FlatDiscount : Discount
    {
        private decimal flatAmount;
        public FlatDiscount(decimal amount)
        {
            Name = "Flat Discount";
            flatAmount = amount;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
            => flatAmount * Math.Min(quantity, 1);
    }
    public class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One Discount";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
            => (quantity > 1) ? (price / 2) * (quantity / 2) : 0;
    }
}
