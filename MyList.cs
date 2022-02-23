using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // MyList<T> şeklinde yarazak bu işaretler arasında istediğimiz bir veri tipini tutabiliriz.
    // T işareti veri tipini simgeler
    class MyList<T>
    {
        // ekeleme fonksiyonunu yazarsak parametre olarak T vermemiz gerekir .
        // bir dizi referansı tutalım. Tutualacak dizinin tipini T belirler. listeyi new ile belirlediğimizde dizi oluşturulmalı
        // bunun için ctor ile constructor tnaımlarız
        T[] items;

        //Constructor tnaımladık. 
        public MyList()
        {
            // sıfır elemanlı bir dizi tanımladık 
            items = new T[0];

        }
        public void Add(T item)
        {
            // eklenecek olan isimleri tutmamız gerekir. bunun için bir dizi yönetir
            // Dizi Constructor ile new olurken eleman sayısı sıfırdır.

            // eleman eklemek istersek dizinin eleman sayısını +1 artırmak gerekir bunun için de length kullanırız
            // dizi eleman sayısını arttırma işlemi yaptığımızda ilk tanımlanan dizinin referans adresi yok olur 
            //Bunun için geçici bir dizide bunu tutmak gerekir.
            T[] tempArray = items; // items dizisinin referans numarsını tempArray tutacak 
            items = new T[items.Length + 1]; // dizimizin eleman sayısını +1 artırır.

            // tempArray deki elemanları tekrar alalım
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // 

            }

            // son eklenecek olan elemanı itemss dizisine ekleyelim
            items[items.Length - 1] = item;  // items.Length - 1 demek dizi 6 elemanlı ise 0 dan başladığı için 5.yere ekle 

        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Item
        {
            get { return items; }
        }
    }
}