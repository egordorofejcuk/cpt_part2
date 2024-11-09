using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Circle: Shape 
    {
        public double radius;
        public Circle(double _radius)
        {
            radius = _radius;
        }
        public override double GetArea() 
        {
            return radius * radius * Math.PI;
        }
    }
}
