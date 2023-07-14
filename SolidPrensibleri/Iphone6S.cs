using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrensibleri
{
    internal class Iphone6S : Telefon,IFoto
    {
        public void FotografCek()
        {
            Console.WriteLine("Foto Çekildi");
        }

        public override void TelefonEt()
        {
            Console.WriteLine("Telefon edildi");
        }
    }
}
