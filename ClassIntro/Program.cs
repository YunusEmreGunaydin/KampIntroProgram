using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlemeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = " Kerem Varış";
            kurs1.IzlemeOranı = 68;

            Kurs kurs3 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlemeOranı = 68;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlemeOranı { get; set; }
    }
}
