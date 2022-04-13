using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class AppealManager
    {
        // Başvuru yap demek.
        //Method injection yaptık.
        public void DoAppeal(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            // Birden fazla loglamayı kullanabilir hale getirdik.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        // Kredi ön bilgilendirme yap demek.
        public void DoCreditPreliminaryInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
