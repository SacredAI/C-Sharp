using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Month
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> months = new Dictionary<String,int>();
            months.Add("january", 31);
            months.Add("feburay", 28);
            months.Add("march", 31);
            months.Add("april", 30);
            months.Add("may", 31);
            months.Add("june", 30);
            months.Add("july", 31);
            months.Add("august", 31);
            months.Add("september", 30);
            months.Add("october", 31);
            months.Add("november", 30);
            months.Add("december", 31);

            Console.WriteLine("Please imput a month");
            String input = Console.ReadLine();
            input = input.ToLower();

                int output = months[input];
            Console.WriteLine(input + " has " + output + " Days in it");
            

            Console.ReadKey();
        }
    }
}
