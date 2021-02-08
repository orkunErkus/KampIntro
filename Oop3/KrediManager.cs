using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    interface IKrediManager // tüm kredilerde hesaplama ortaktır ancak içerik kodları hesaplamaları farklıdır 
    {
        void Hesapla();
        void BiseyYap();
    }
}
