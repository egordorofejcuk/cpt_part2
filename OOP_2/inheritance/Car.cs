using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Car: Vehicle
    {
        public int numDoors { get; set; }
        public Car(string _model, int _year, int _numDoors)
            : base(_model, _year)
        {
            numDoors = _numDoors;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Количество дверей: {numDoors}");
        }
    }
}
