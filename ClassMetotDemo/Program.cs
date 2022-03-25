using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            CustomerManager customerManager = new CustomerManager();

            customer.Id = 1;
            customer.FirstName = "John";
            customer.LastName = "Wich";
            customer.Age = 43;
            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.List(customer);
            customerManager.AllProperties(customer);

            

        }
    }
}
