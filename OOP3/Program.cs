using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Böylelikle inheritance gibi interfacelerde referans numarasını tutar.
            ICreditManager homeCreditManager = new HomeCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager(); 
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager(); 

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { fileLoggerService,databaseLoggerService};
            AppealManager appealManager = new AppealManager();
            // Böylelikle birden fazla loglama yapabilir duruma getirdik.
            appealManager.DoAppeal(personalFinanceCreditManager,loggers);


            List<ICreditManager> credits = new List<ICreditManager>() { homeCreditManager};

            appealManager.DoCreditPreliminaryInformation(credits);
        }
    }
}
