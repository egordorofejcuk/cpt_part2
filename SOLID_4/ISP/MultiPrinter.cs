using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class MultiPrinter: Printer, Scaner
    {
        public void print()
        {
            Console.WriteLine("printer is printing");
        }
        public void scan()
        {
            Console.WriteLine("printer is scanning");
        }
    }
}
