using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // kendi generigimizi oluşturalım
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // referans numarası uçmasın deger tutucu
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)  // deger tutucudan degerleri geri almak
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
