using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslem
{
    class DortIslem
    {
        public int Topla(int number1,int number2)
        {
            int total = number1 + number2;
            return total;
        }
        public int Cikar(int number1,int number2)
        {
            int total = number1 - number2;
            return total;
        }
        public int Bolme(int number1, int number2)
        {
            int total = number1 / number2;
            return total;
        }
        public int Topla(int number1, int number2,int number3)
        {
            int total = number1 + number2 + number3;
            return total;
        }
    }
}
