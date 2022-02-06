using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[10];
            Console.Write("Unsorted array: ");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 1000);
                Console.Write(a[i] + " ");
            }

            for (int i = 0; i <= a.Length - 1; i++)
            {
                for(int j = 0; j <= a.Length - 1 - 1; j++)
                {
                    if (a[j] > a[j + 1]) {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp; 
                    }
                }
            }

            Console.WriteLine();
            Console.Write("Sorted Array: ");
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
