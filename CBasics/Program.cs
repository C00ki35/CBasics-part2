
using System;
using System.Xml;

namespace CBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            var random = new Random();
            Console.WriteLine(random.Next());

            var randomNumber = new Random().Next(1, 10);
            Console.WriteLine(randomNumber);
            Console.WriteLine((int)'a');

            var randomLetter = new Random();
            for (var i = 0; i <= 6; i++)
            {
                Console.Write((char)('a' + randomLetter.Next(0, 26)));
            }
            Console.WriteLine();

            const int passwordLength = 6;
            var buffer = new char[passwordLength];
            for (var x = 0; x < passwordLength; x++)
            {
                buffer[x] = (char)('a' + randomLetter.Next(0, 26));
                var password = new string(buffer);
                if (x == 4)
                {
                    Console.Write("Your password is {0}", password);
                }
            }
            Console.WriteLine();

            t1
            for (var n = 0; n <= 100; n++)
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine(n);
                }
            }

            //t2
            var total = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or \"Ok\" to exit");
                var input = Console.ReadLine();
                if(input == "ok")
                {
                    Console.Write("Your total is {0}", total);
                    break;
                }
                total += Int16.Parse(input);
            }
            Console.WriteLine();

            //t3
            

        }   
    }
}
