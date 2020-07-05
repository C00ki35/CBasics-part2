
using System;
using System.Xml;

namespace CBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            var numbers = new[] { 4,3,4,2,66,8 };
            Console.WriteLine(numbers.Length);

            var indexofEight = Array.IndexOf(numbers, 8);
            Console.WriteLine(indexofEight);


            //Clear sets given number of items to zero, false or null
            Array.Clear(numbers, 0, 2);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            //Copy method 
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var item in another)
            {
                Console.WriteLine(item);
            }

            //Sort
            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse
            Console.WriteLine("Reversed");
            Array.Reverse(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }




        }
    }
}
