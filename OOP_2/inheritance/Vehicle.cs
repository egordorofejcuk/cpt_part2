using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Vehicle
    {
        public string model { get; set; }
        public int year { get; set; }
        public Vehicle(string model, int year)
        {
            this.model = model;
            this.year = year;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{year}, {model}");
        }
    }
}
