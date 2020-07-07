
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace CBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Arrays
            //var numbers = new[] { 4,3,4,2,66,8 };
            //Console.WriteLine(numbers.Length);

            //var indexofEight = Array.IndexOf(numbers, 8);
            //Console.WriteLine(indexofEight);


            ////Clear sets given number of items to zero, false or null
            //Array.Clear(numbers, 0, 2);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine();

            ////Copy method 
            //var another = new int[3];
            //Array.Copy(numbers, another, 3);
            //foreach (var item in another)
            //{
            //    Console.WriteLine(item);
            //}

            ////Sort
            //Array.Sort(numbers);
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            ////Reverse
            //Console.WriteLine("Reversed");
            //Array.Reverse(numbers);
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //LISTS - are mutable
            //var numbersList = new List<int>() { 1, 2, 3, 5 };
            //numbersList.Add(9);
            //numbersList.AddRange(new int[3] { 6, 77, 77 });

            //foreach (var n in numbersList)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine("The index of number 2 is: " + numbersList.IndexOf(2));
            //Console.WriteLine("The index of number 2 is: " + numbersList.LastIndexOf(2));
            //Console.WriteLine("Total number of numbers: " + numbersList.Count);

            //Excercises
            //var friends = new List<String>();
            //while (true)
            //{
            //    Console.WriteLine("Add a friend: ");
            //    var input = Console.ReadLine();


            //    friends.Add(input);
            //    var totalLikes = friends.Count;

            //    if (input == "")
            //    {
            //            Console.WriteLine("0 likes");
            //        break;
            //    }
            //    if (totalLikes == 1)
            //    {
            //        Console.WriteLine(friends[0] + " likes your post");
            //    }
            //    if (totalLikes == 2)
            //    {
            //        Console.WriteLine(friends[0] + ", " + friends[1] + " likes your post");
            //    }
            //    if(totalLikes > 2)
            //    {
            //        Console.WriteLine(friends[0] + ", " + friends[1] + " and " + (friends.Count - 2) + " other(s) like your post.");


            //    }



            //Console.WriteLine("Enter your name: ");
            //var input = Console.ReadLine();
            //char[] chars = input.ToCharArray();
            //Array.Reverse(chars);

            //var reversed = "";
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    reversed += chars[i];
            //}

            //Console.WriteLine(reversed);

            //var friends = new List<String>();


            var givenNumbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                var numberInput = Console.ReadLine();
                var isFound = givenNumbers.Exists(n => n == Convert.ToInt16(numberInput));
                if (!isFound)
                {
                    givenNumbers.Add(Convert.ToInt32(numberInput));
                }
                else
                {
                    Console.WriteLine("please select another number");
                }
                if (givenNumbers.Count == 5)
                {
                    givenNumbers.Sort();
                    foreach (var number in givenNumbers)
                    {
                        Console.WriteLine(number);
                    }
                }
            }
        }
    }
}
 
    
