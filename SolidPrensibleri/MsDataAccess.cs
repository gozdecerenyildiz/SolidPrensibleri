using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrensibleri
{
    internal class MsDataAccess : ILogger
    {
        public void LogKaydet(string data)
        {
            Console.WriteLine(data + " MS Dataya Kaydedildi!");
        }
    }
}
