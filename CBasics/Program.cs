
using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace CBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            //Strings
            var name = "Jonathon Parker";
            //Console.WriteLine(name.ToUpper());

            var index = name.IndexOf(' ');
            var firstName = name.Substring(0, index);
            var surname = name.Substring(index + 1);
            Console.WriteLine(firstName);
            Console.WriteLine(surname);

            //Split
            var fullName = name.Split(' ');
            Console.WriteLine(fullName[0]);
            Console.WriteLine(fullName[1]);

            //Returns a new string, not the original
            //Console.WriteLine(name.Replace('P', 'H'));

            //Console.WriteLine("Enter your name: ");
            //var input = Console.ReadLine();

            //if (String.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Input not valid");
            //} else
            //{
            //    Console.WriteLine("Ok");
            //}

            //ToString
            float price = 28.77f;
            Console.WriteLine("Price: {0}", price.ToString("C"));

            var sentence = "A very long A very long sentence that is to be summarised";
            var summary = StringUtility.SummerizeText(sentence, 27);
            Console.WriteLine(summary);
        }


        
    }
}


