using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrensibleri
{
    internal class Logger
    {
        ILogger _logger;
        public Logger(ILogger logger)
        {
            _logger = logger;
        }
        public void LogYaz(string veri)
        {
            _logger.LogKaydet(veri);
        }
    }
}
