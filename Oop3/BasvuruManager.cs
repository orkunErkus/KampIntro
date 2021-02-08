using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        //methot injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            krediManager.Hesapla();
            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
