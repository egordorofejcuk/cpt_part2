using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
     public class Logger: ILogger
    {
        public void LogInfo()
        {
            Console.WriteLine("INFO: completed");
        }
    }
}
