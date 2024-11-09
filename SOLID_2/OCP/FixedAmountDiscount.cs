using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class FixedAmountDiscount : Discount
    {
        double deduction;
        public FixedAmountDiscount(double _deduction)
        {
            this.deduction = _deduction;
        }
        public override double CalculateDiscount(double price)
        {
            return price - deduction;
        }
    }
}
