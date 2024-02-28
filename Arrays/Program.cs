using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Mustafa";
            //string student2 = "Nazlı";
            //string student3 = "Elif";

            string[] students = new string[3] { "Mustafa", "Nazlı", "Elif" };

            string[] students2 = { "Mustafa", "Nazlı", "Elif" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                {"İstanbul", "İzmit", "Balıkesir" },
                {"Ankara", "Konya", "Kırıkkale" },
                {"Antalya", "Adana", "Mersin" },
                {"Rize", "Trabzon", "Samsun" },
                {"İzmir", "Muğla", "Manisa" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }

                Console.WriteLine("*************");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
