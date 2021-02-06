using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Eklendi : " + urun.Adi);
        }       
        
        public void Ekle2(string Adi , string Aciklama , double Fiyati)
        {
            Console.WriteLine("Eklendi : " + Adi);
        }
    }
}
