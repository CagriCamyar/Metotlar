using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//operasyon tutar

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);

        }
        public void Ekle2(string Adi, string Aciklama, double Fiyati, int stokAdedi)
        {

            Console.WriteLine("Tebrikler. Sepete Eklendi : " + Adi);
        }
    }
}