using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    class Program
    {
        static string[] arg = new string[1];

        static void Main(string[] args)
        {

            Console.ReadKey();
        }

        static void AboveGround()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("West of House");
            Console.ResetColor();

            Console.WriteLine("This is an open field west of a white house, with a boarded front door.");
            Console.WriteLine("There is a small mailbox here.");
            Console.WriteLine("A rubber mat saying 'Welcome to Zork!' lies by the door.");
        }

        static void input(string input)
        {
            string[] args = input.Split(' ');

            if (args[1].ToLower().Equals("north") || args[1].ToLower().Equals("n"))
            {

            }else if (args[1].ToLower().Equals("south") || args[1].ToLower().Equals("s"))
            {

            }
            else if (args[1].ToLower().Equals("east") || args[1].ToLower().Equals("e"))
            {

            }
            else if (args[1].ToLower().Equals("north") || args[1].ToLower().Equals("n"))
            {

            }
            else if (args[1].ToLower().Equals("up") || args[1].ToLower().Equals("u"))
            {

            }
            else if (args[1].ToLower().Equals("down") || args[1].ToLower().Equals("d"))
            {

            }
            else if (args[1].ToLower().Equals("look") || args[1].ToLower().Equals("l"))
            {

            }

        }
    }
}
