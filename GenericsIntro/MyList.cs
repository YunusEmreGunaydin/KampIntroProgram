using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor
        public MyList()
        {
            items = new T[0];
        }
        // T burada programcı hangi değer tipi verirse ona göre şekillensin demek için böyle yaparız.
        public void Add(T item)
        {
            // tempArray geçici dizi anlamına gelir.
            T[] tempArray = items; // Böyle yaparak items'ı tutuyoruz ve de geçici referans tutucu olarak görev görüyor.
            //Böylelikle eleman sayını bir arttırabiliyoruz.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                //temp array'e geçici olarak verdiğimiz elemanları items'a aktarırız böylelikle.
                items[i] = tempArray[i];
            }

            //Böylelikle itemı items'a eklemiş oluyoruz.
            items[items.Length - 1] = item;
        }
    }
}
