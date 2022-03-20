using System;

namespace DegerVeReferansTip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type ->Değer Tip (float,decimal,int,string,double)
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 30;
            Console.WriteLine(number1);

            //Referance Type -> Referans Tip (array,class,interface)
            int[] numbers1 = new int[] {1,2,3 };
            int[] numbers2 = new int[] {20,30,40};
            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]);
            
        }
    }
}
