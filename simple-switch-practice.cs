using System;
using System.Net.WebSockets;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // practicing switches in C#
            // this is an efficient alternative to else if statements
            
            Console.WriteLine("What day is it today? ");
            string day = Console.ReadLine();

            switch (day)
            {
               case "Monday" :
                   Console.WriteLine("It's Monday! ");
                   break;
               case "Tuesday" :
                   Console.WriteLine("It's Tuesday! ");
                   break;
               case "Wednesday" :
                   Console.WriteLine("It's Wednesday! ");
                   break;
               case "Thursday" :
                   Console.WriteLine("It's Thursday! ");
                   break;
               case "Friday" :
                   Console.WriteLine("It's Friday! ");
                   break;
               case "Saturday" :
                   Console.WriteLine("It's Saturday! ");
                   break;
               case "Sunday" :
                   Console.WriteLine("It's Sunday! ");
                   break;
               default: 
                   Console.WriteLine(day + " is not a day....");
                   break;
               
            }
            
            Console.ReadKey();
        }
    }
}
