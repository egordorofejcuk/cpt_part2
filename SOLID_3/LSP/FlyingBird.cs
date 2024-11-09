using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class FlyingBird: Bird, Flyable
    {
        public override void eat()
        {
            Console.WriteLine("Flying bird eat");
        }
        public void fly() 
        {
            Console.WriteLine("Flying bird fly");
        }
    }
}
