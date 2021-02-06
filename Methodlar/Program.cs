using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun { };
            urun1.Adi = "elma";
            urun1.Aciklama = "amasya elması";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun { };
            urun2.Fiyati = 80;
            urun2.Adi = "karpuz";
            urun2.Aciklama = "diyarbakır";

            Urun[] urunler = new Urun[] { urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Adi);
                Console.WriteLine("------------");
            }

            Console.WriteLine("-----methotlar--------!");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut" , "yeşil" , 12);
            sepetManager.Ekle2("elma" , "kırmızı" , 11);
            sepetManager.Ekle2("karpuz" , "diyarbakır" , 13);
        }
    }
}
