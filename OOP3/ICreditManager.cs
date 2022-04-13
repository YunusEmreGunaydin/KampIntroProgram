using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //interface olduğunu anlamak için başına büyük I getiririz.
    //Birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.(Interface kullanım amacı)
    interface ICreditManager
    {
        void Calculate();
        void DoSomething();
        
    }
}
