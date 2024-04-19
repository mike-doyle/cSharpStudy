using System;
using System.Net.WebSockets;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // for loops practice
            // repeats some code a FINITE amount of times

            /*for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("HAPPY NEW YEAR!");
            
            Console.ReadKey();
        }
    }
}
