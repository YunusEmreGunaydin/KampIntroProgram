using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Koleksiyonlara sonradan eleman eklenebilir ve herhangi bir problem oluşturmaz.
            List<string> names = new List<string> {"Emre","Hasan","Hüseyin" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            //Dizilerde böyle yapamıyoruz. :(
            names.Add("Halil");
            Console.WriteLine(names[3]);
        }
    }
}
