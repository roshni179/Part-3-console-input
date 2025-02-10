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
            string age;
            string year;
          
           Console.WriteLine("What's your name?");
           name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}");
            Console.WriteLine("Your age?");

            age = Console.ReadLine();
            Console.WriteLine($"Cool, you're {age} years old.");

           
            Console.WriteLine($"What is the current year?");
                 Console.WriteLine(DateTime.Now.Year);
            year = Console.ReadLine();
         Console.WriteLine($"Oh it is {DateTime.Now.Year}.");
            
        }
    }
}
