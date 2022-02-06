using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the year");
            String year = Console.ReadLine();
            Console.WriteLine("Please Enter the Month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the days");
            long day = long.Parse(Console.ReadLine());

            for (int i = 1; i < month; i++)
            {
                if (i == 1)
                {
                    day += 31;
                    Console.WriteLine("1");
                }
                else if (i == 2)
                {
                    day += 28;
                    Console.WriteLine("2");
                }
                else if (i == 3)
                {
                    day += 31;
                    Console.WriteLine("3");
                }
                else if (i == 4)
                {
                    day += 30;
                    Console.WriteLine("4");
                }
                else if (i == 5)
                {
                    day += 31;
                    Console.WriteLine("5");
                }
                else if (i == 6)
                {
                    day += 30;
                    Console.WriteLine("6");
                }
                else if (i == 7)
                {
                    day += 31;
                    Console.WriteLine("7");
                }
                else if (i == 8)
                {
                    day += 31;
                    Console.WriteLine("8");
                }
                else if (i == 9)
                {
                    day += 30;
                    Console.WriteLine("9");
                }
                else if (i == 10)
                {
                    day += 31;
                    Console.WriteLine("10");
                }
                else if (i == 11)
                {
                    day += 30;
                    Console.WriteLine("11");
                }
                if (month == 12)
                {
                    day += 31;
                    Console.WriteLine("12");
                }
            }
            long days = day / 365;
            Console.WriteLine(year + "." + days);
            
            Console.ReadKey();
        }
    }
}
