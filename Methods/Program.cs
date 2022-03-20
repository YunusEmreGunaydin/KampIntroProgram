using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Elma";
            product1.Price = 5;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır";

            Product[] products = new Product[] {product1,product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Price);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("---------Metotlar----------");
            //inctance - class örneği oluşturmuş oluyoruz.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
        }
    }
}
