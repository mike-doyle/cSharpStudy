using System;
using System.Net.WebSockets;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // beginner string methods in C#

            string fullName = "Mike Doyle"; 
            string phoneNumber = "123-456-7890";
            
            
            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //phoneNumber = phoneNumber.Replace("-", "/");

            //Console.WriteLine(fullName);
            //Console.WriteLine(phoneNumber);
            
            //string userName = fullName.Insert(0,"@");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length);

            string firstName = fullName.Substring(0, 4);
            string lastName = fullName.Substring(5, 5);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            Console.ReadKey();
            
        }
    }
}
