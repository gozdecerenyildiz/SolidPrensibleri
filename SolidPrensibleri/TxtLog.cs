using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrensibleri
{
    internal class TxtLog : ILogger
    {
        public void LogKaydet(string data)
        {
            Console.WriteLine(data + " Txt Kaydedildi!");
        }
    }
}
