﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int Toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + Toplam);
        }

        public void Cikarma(int sayi1, int sayi2)
        {

            int Sonuc = sayi1 - sayi2;
            Console.WriteLine(Sonuc);

        }
    }
}
