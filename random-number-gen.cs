using System;
using System.Net.WebSockets;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //generating random numbers
            
            Random random = new Random();

            //int num = random.Next(1, 21);
            //double num = random.NextDouble();

            // similar results as rolling three 7-sided die
            int num1 = random.Next(1, 8);
            int num2 = random.Next(1, 8);
            int num3 = random.Next(1, 8);

            
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);


            //Console.ReadKey();
            
            
        }
    }
}
