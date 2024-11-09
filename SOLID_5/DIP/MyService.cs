using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class MyService
    {
        private readonly ILogger _logger;
        public MyService(ILogger logger)
        {
            _logger = logger;
        }

        public void Process()
        {
            _logger.LogInfo();
        }
    }
}
