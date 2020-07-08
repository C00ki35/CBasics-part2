
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace CBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('%', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('%', 10)
                .Remove(3, 6)
                .Insert(0, new string('-', 5));
            Console.WriteLine(builder);
            Console.WriteLine("Ninth letter is:  " + builder[3]);


            //Console.WriteLine("Add numbers seperated by hyphen");
            //var input = Console.ReadLine();
            //var consecString = new StringBuilder(input);
            //consecString.Replace("-", string.Empty);
            //var numbers = consecString.ToString();

            //var firstNumber = Convert.ToInt16(numbers[0]);
            //var count = 1;
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    var n = Convert.ToInt16(numbers[i]);
            //    if(n != (firstNumber + count))
            //    {
            //        Console.WriteLine("Not consecutive");
            //        break;
            //    }
            //    if(count == numbers.Length - 1)
            //    {
            //        Console.WriteLine("ALL CON");
            //    }
            //    count++;    
            //}

            //Console.WriteLine("Enter numbers seperated by commas");
            //var input = Console.ReadLine();
            //if (String.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Not Valid");
            //} else
            //{
            //    if(input.Split(',').Distinct().Count() != input.Split(',').Length)
            //    {
            //        Console.WriteLine("Duplicates");
            //    }
            //}

            //Console.Write("Please input a time (HH:mm): ");

            //var givenTime = Console.ReadLine();

            //try
            //{
            //    var time = DateTime.Parse(givenTime);
            //    Console.WriteLine("Ok");

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("invalid");
            //}

            //Console.WriteLine("Enter some text here: ");
            //var text = Console.ReadLine();

            //var password = text.Split(' ');
            //var newString = new StringBuilder();
            //for (int i = 0; i < password.Length; i++)
            //{
            //    newString.Append(password[i][0].ToString().ToUpper());
            //    var restOfString = password[i].ToString().Substring(1);
            //    newString.Append(restOfString.ToLower());
            //}

            //Console.WriteLine(newString);

            Console.WriteLine("Write a sentence here");
            var input = Console.ReadLine().ToUpper();
            var splitWord = input.ToCharArray();

            var letterList = new List<string>();
            foreach (var letter in splitWord)
            {
                var l = letter.ToString();
                if(l == "A" || l == "E" || l == "I" || l == "O" || l == "U")
                {
                    letterList.Add(letter.ToString());
                }
            }
            Console.WriteLine("Number of vowels: " + letterList.Count);
        }

        

    }
}


