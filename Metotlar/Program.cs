using System;

namespace Metotlar
{
    class Program
    {

        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Fiyati = 40;
            urun3.Aciklama = "Armudun iyisi";



            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Adi + " : " + urunler[i].Fiyati + " : " + urunler[i].Aciklama);
            }

            Console.WriteLine();

            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi + " : " + urun.Fiyati + " : " + urun.Aciklama);

            }

            Console.WriteLine("--------------------Metotlar----------------------");

            //instance - örnek
            //encapsulation 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //Metot çağırdım
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 24, 1);
            sepetManager.Ekle2("Karpuz", "Db karpuzu", 79, 5);

        }
    }
}