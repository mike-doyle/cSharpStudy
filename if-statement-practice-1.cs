using System;
using System.Net.WebSockets;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            // pacticing if statements in C#
            // creating a read line for user to input data, converting from string to int
            

            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 100)
            {
                Console.WriteLine("You are way too old to sign up...");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are now signed up! ");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet... ");
            }
            else
            {
                Console.WriteLine("You must be 18 years or older to sign up. ");
            }
            
            Console.ReadKey();
        }
    }
}
