
using System;
using System.Xml;

namespace CBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            //var random = new Random();
            //Console.WriteLine(random.Next());

            //var randomNumber = new Random().Next(1, 10);
            //Console.WriteLine(randomNumber);
            //Console.WriteLine((int)'a');

            //var randomLetter = new Random();
            //for (var i = 0; i <= 6; i++)
            //{
            //    Console.Write((char)('a' + randomLetter.Next(0, 26)));
            //}
            //Console.WriteLine();

            //const int passwordLength = 6;
            //var buffer = new char[passwordLength];
            //for (var x = 0; x < passwordLength; x++)
            //{
            //    buffer[x] = (char)('a' + randomLetter.Next(0, 26));
            //    var password = new string(buffer);
            //    if (x == 4)
            //    {
            //        Console.Write("Your password is {0}", password);
            //    }
            //}
            //Console.WriteLine();

            ////t1
            //for (var n = 0; n <= 100; n++)
            //{
            //    if (n % 3 == 0)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}

            ////t2
            //var total = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enter a number or \"Ok\" to exit");
            //    var input = Console.ReadLine();
            //    if(input == "ok")
            //    {
            //        Console.Write("Your total is {0}", total);
            //        break;
            //    }
            //    total += Int16.Parse(input);
            //}
            //Console.WriteLine();

            //t3

            var secretNumber = new Random().Next(1, 9);
            //Console.WriteLine(secretNumber);
            //for(var c = 3; c >= 0; c--)
            //{
            //    Console.WriteLine("Guess the number: ");
            //    var input = Console.ReadLine();
            //    var number = Convert.ToInt32(input);

            //    if (number == secretNumber)
            //    {
            //        Console.WriteLine("Congratulations, you guessed the right number.");
            //        break;
            //    } else
            //    {
            //        Console.WriteLine("Sorry, that's not right. You have " + (c - 1) + " goes left.");
            //    }
            //}

            Console.Write("Enter your numbers seperated by a comma: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);

        }


    }  
    }

