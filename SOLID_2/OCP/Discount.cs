﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public abstract class Discount
    {
        public abstract double CalculateDiscount(double price);
    }
}
