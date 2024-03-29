﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Mustafa Kavuşdu";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            //sentence = "My name is Nazlı Şahin";

            bool result3 = sentence.EndsWith("u");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("Mustafa");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3, 4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2,5);

            Console.WriteLine(result13);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Bilecik";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Eskişehir";

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
