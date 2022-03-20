using System;

namespace KampIntroProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool sistemeGirisYapmisMi = true;
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi oku");
            }

           
        }
    }

}
