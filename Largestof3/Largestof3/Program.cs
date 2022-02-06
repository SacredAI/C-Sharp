using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largestof3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the First Number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Second Number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Three Number");
            int number3 = int.Parse(Console.ReadLine());

            if(number1 > number2 && number1 > number3)
            {
                Console.WriteLine(number1 + " Is the Biggest Number");
            } else if (number2 > number3)
            {
                Console.WriteLine(number2 + " Is the Biggest Number");
            }
            else
            {
                Console.WriteLine(number3 + " Is the Biggest Number");
            }

            Console.ReadKey();
        }
    }
}
