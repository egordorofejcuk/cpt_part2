using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class PercentageDiscount : Discount
    {
        double percent;
        public PercentageDiscount(double _percent)
        {
            this.percent = _percent;
        }
        public override double CalculateDiscount(double price)
        {
            return price * percent / 100;
        }
    }
}
