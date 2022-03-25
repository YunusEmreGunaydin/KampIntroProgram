using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
      

        public void Add(Customer customer)
        {

            Console.WriteLine(customer.FirstName +" "+ customer.LastName + " " + "added.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " +"deleted.");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.FirstName +" "+ "listed.");
        }
        public void AllProperties(Customer customer)
        {
            Console.WriteLine(" Id= {0} First Name= {1} Last Name= {2} Age= {3} ",customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }
    }
}
