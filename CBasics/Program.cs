
using System;
using System.Xml;

namespace CBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var i = 1; i <= 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var name = "Something here";
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            var names = new string[3] { "Dan", "Simon", "Frank" };
            foreach (var person in names)
            {
                Console.WriteLine(person);
            }


            var x = 0;
            while(x < 10)
            {
                Console.WriteLine(x);
                x++;
            }

            while (true)
            {
                Console.Write("Enter your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input)) { 
                    break;
                }
            }
        }   
    }
}
