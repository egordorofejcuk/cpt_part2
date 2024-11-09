using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Bicycle: Vehicle
    {
        public int numberOfGears { get; set; } // Количество передач

        public Bicycle(string _model, int _year, int _numberOfGears)
            : base(_model, _year)
        {
            this.numberOfGears = _numberOfGears;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Количество передач: {numberOfGears}");
        }
    }
}
