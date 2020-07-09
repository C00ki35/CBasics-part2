
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Procedural Programming
            //Console.WriteLine("What's your name?:");
            //var name = Console.ReadLine();
            //var reversedName = reverseName(name);
            //Console.WriteLine(reversedName);

            //Console.WriteLine("Add numbers seperated by hyphen");
            //var input = Console.ReadLine();
            //var numbers = isConsecutive(input);
            //Console.WriteLine(numbers);


            Console.WriteLine("Enter numbers seperated by commas");
            var numberList = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(numberList))
            {
                Console.WriteLine("Not valid");
            } else
            {
                Console.WriteLine(duplicates(numberList));
            }

        }

        public static string duplicates(string text)
        {
            if (text.Split(',').Distinct().Count() != text.Split(',').Length)
            {
                return "Duplicates";
            }
            return "No Duplicates";
        }

        public static string isConsecutive(string text)
        {
            var consecString = new StringBuilder(text);
            consecString.Replace("-", string.Empty);
            var numbers = consecString.ToString();
            var firstNumber = Convert.ToInt16(numbers[0]);
            var count = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                var n = Convert.ToInt16(numbers[i]);
                if (n != (firstNumber + count))
                {
                    return "NOT CONSECUTIVE";
                }
                if (count == numbers.Length - 1)
                {
                    return "ALL CONSECUTIVE";
                }
                count++;
            }
            return "";
        }

        public static string reverseName(string text)
        {
            var array = new char[text.Length];
            for (int i = text.Length; i > 0; i--)
            {
                array[text.Length - i] = text[i - 1];
            }
            return new string(array);
        }
        

    }
}


