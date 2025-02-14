using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

            Console.WriteLine("Part 1: Greetings!");
            Console.WriteLine("------------------------------------");

        Console.WriteLine();

            Console.WriteLine("What's your name?");
            name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Hello, {name}");
            Console.WriteLine();

            Console.WriteLine("Your age?");

          

            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

           Console.WriteLine();
            
     
            year = DateTime.Now.Year;
            Console.WriteLine($"Oh you were born in {year - age}.");
            Console.WriteLine();



            //Part 2 
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Part 2 Integers");
            Console.WriteLine("''''''''''''''''''''''''''''''''''''''''");
            double value1, value2, value3, total;

            Console.WriteLine();

            Console.WriteLine("Enter value 1: ");
            value1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Value 2: ");
            value2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Value 3: ");
            value3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Total Value: ");
            total = value1 + value2 + value3;
            Console.WriteLine(total);


            // 3 Distance
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Part 3 Finding Distance");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            
            double distance1, distance2, distance3, average;

            Console.WriteLine("Distance 1");
            distance1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
          

            Console.WriteLine("Distance 2");
            distance2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Distance 3");
            distance3 = Convert.ToDouble(Console.ReadLine());

            average = distance1 + distance2 + distance3 / 3;
            Console.WriteLine();
            Console.WriteLine("Your total: ");
            Math.Round(average, 2);
            Console.WriteLine(average);

          Console.WriteLine();

            //part 6
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Part 5: Hypotenuse");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine();

            double Side1, Side2, hypotenuse;

            Console.WriteLine("Side 1 value: ");
            Side1 = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine();

            Console.WriteLine("Side 2 value:  ");
            Side2 = Convert.ToDouble(Console.ReadLine());
            hypotenuse = Math.Pow(Side1, 2) + Math.Pow(Side2, 2);




            Console.WriteLine($"The hypotenuse is: {hypotenuse} units");
        }

    }
}

   
