using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_console_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int year;
          
           Console.WriteLine("What's your name?");
           name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}");
            Console.WriteLine("Your age?");

            age = Console.ReadLine();
            Console.WriteLine($"Cool, you're {age} years old.");

           
            Console.WriteLine($"What is the current year?");
            
            year = DateTime.Now.Year;
            Console.WriteLine($"Oh you were born in {year - age}.");
            
        }
    }
}
