using System;
using System.Net.WebSockets;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input to caluclate the hypotenuse of a triangle in C#
            
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("The Hypotenuse is: " + c);

            Console.ReadKey();
            
        }
    }
}
