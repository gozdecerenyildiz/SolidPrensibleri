using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrensibleri
{
    internal class XMLLog : ILogger
    {
        public void LogKaydet(string veri)
        {
            Console.WriteLine(veri + " XML'e Kaydedildi!");
        }
    }
}
