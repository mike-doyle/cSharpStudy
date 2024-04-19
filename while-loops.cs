using System;
using System.Net.WebSockets;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // while loop = repeats some code while some condition remains true
            
            
            string name = "";
            
            

            while (name == "")
            { 
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            }
            
            
            Console.WriteLine("Hello " + name);
            
            Console.ReadKey();
        }
    }
}
