using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polymorphism
{
    public class Dog: Animal
    {
        public Dog(string _name) : base(_name) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{name} говорит: гав!");
        }
    }
}
