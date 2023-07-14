using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrensibleri
{
    internal class Program:ILogger
    {
        static void Main(string[] args)
        {


            //SOLİD PRENSİPLERİ
            //-----------------------------------
            //1.S ingle Responsibility Principle (Her sınıfın veya methodun tek bir amacı olmalı)
            //2.O pen / Closed Principle
            //3.L iskov‘s Substitution Principle 
            //4.I nterface Segregation Principle
            //5.D ependency Inversion Principle
            //-----------------------------------



            //Logger logger = new Logger(new XMLLog());

            //logger.LogYaz("Mustafa Kullanıcısı giriş yaptı şu tarihte: "+DateTime.Now);

            MüstakilEv müstakilEv = new MüstakilEv();

            new Apartman();
            int a = 3;
            var tipim = new {




                İsim = "Mustafa", Soyisim = "Akdemir"
           };
            var tipim2 = new
            {




                İsim = "Mustafa",
                Soyisim = "Akdemir",
                deneme = a
            };
            var tipim3 = new
            {




                İsim = "Mustafa",
                Soyisim = "Akdemir",
                deneme = a,
                test ="f"
            };
            Console.WriteLine(tipim.GetType());
            Console.WriteLine(tipim2.GetType());
            Console.WriteLine(tipim3.GetType());



            Console.ReadLine();






        }

        public void LogKaydet(string data)
        {
            throw new NotImplementedException();
        }
    }
}
