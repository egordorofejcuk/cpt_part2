using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Rectangle: Shape
    {
        public double height;
        public double width;
        public Rectangle(double _height, double _width)
        {
            this.height = _height;
            this.width = _width;
        }
        public override double GetArea()
        {
            return height * width;
        }
    }
}
