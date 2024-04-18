using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 3.14;
            double y = 5;
            
            double a = Math.Pow(x, 3);
            double b = Math.Sqrt(x);
            double c = Math.Abs(x);
            double d = Math.Round(x);
            double e = Math.Ceiling(x);
            double g = Math.Max(x, y);
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(g);

            Console.ReadKey();
        }
    }
