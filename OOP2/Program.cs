using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Yunus Emre";
            customer1.LastName = "Günaydın";
            customer1.TcNumber = "21414232343";
            
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Business";
            customer2.TaxNumber = "1234567890";


            //Customer sınıfı çocuklarının referans numaralarını tutabilir ve bunu da inheritance sayesinde yapar.
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer3);
            
        }
    }
}
