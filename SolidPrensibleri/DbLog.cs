using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrensibleri
{
    internal class DbLog : ILogger
    {
        public void LogKaydet(string data)
        {
            Console.WriteLine(data + " DataBase'e Kaydedildi!");
        }
    }
}
