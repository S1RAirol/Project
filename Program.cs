using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingApp
{
    internal class GreetingProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter the total number of enrolled courses:");
            int course = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the price of your favorite book:");
            Double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("=========== Greeting App ================");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total number of Enrolled Course: " + course);
            Console.WriteLine("Price of favorite book: " + price);

            Console.WriteLine("Please press any key to exit....");
            Console.ReadKey();
        }
    }
}
