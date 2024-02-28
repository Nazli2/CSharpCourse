using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); // referans oluşturdum yani örneğini oluşturdum...
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Bilecik";
            customer.Id = 1;
            customer.FirstName = "Mustafa";
            customer.LastName = "Kavuşdu";

            Customer customer2 = new Customer
            {
                Id = 2, City = "Eskişehir", FirstName = "Nazlı", LastName = "Şahin"
            };

            Console.WriteLine(customer.FirstName);

            Console.ReadLine();
        }
    }

  
   
}
