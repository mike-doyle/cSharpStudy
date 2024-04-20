using System;
using System.Net.WebSockets;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // nested loops practice
            // nested loops = loops inside of other loops
            // use cases vary, tend to be used in sorting algorithms
            
            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What symbol?: ");
            string symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
