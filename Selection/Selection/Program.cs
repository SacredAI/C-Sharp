using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int number2 = int.Parse(Console.ReadLine());

            if(number1 > number2)
            {
                Console.WriteLine(number1 + " Is the Bigger number");
            } else if(number1 == number2)
            {
                Console.WriteLine("The Numbers are equal");
            }
            else
            {
                Console.WriteLine(number2 + " Is the Bigger number");
            }

            Console.ReadKey();
        }
    }
}
