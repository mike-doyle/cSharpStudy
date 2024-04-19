using System;
using System.Net.WebSockets;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // logical operators in C#
           
           // && (AND)
           // || (OR)
           
           Console.WriteLine("What's the temperature outside?: ");
           double temp = Convert.ToDouble(Console.ReadLine());

           if (temp >= 10 && temp <= 25)
           {
              Console.WriteLine("It's warm outside! "); 
           }
           else if (temp <= -50 || temp >= 50)
           {
               Console.WriteLine("DO NOT GO OUTSIDE!!");
           }
            Console.ReadKey();
        }
    }
}
