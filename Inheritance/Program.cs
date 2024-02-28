using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.City = "Bilecik";
            // Degisiklik yapildi mesela. Sanirim bu yeni olusturuldu. Bir git reposu baslatacagiz.evet yeni proje bu ..

            Person[] persons = new Person[3]
                {
                    new Customer{FirstName="Mustafa"}, 
                    new Person{FirstName="Nazlı"}, 
                    new Student{FirstName="Seba"}
                };

            foreach (var  person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person 
    {
        public string Department { get; set; }
    }


}
