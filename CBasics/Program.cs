using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGoldCustomer = false;
            float price = (isGoldCustomer) ? 20.45f : 44.35f;
            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("Its Autumn");
                    break;
                case Season.Winter:
                    Console.WriteLine("Its Winter");
                    break;
                default:
                    Console.WriteLine("No season");
                    break;
            }

            //t1

            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            var isValid = (number > 0 && number < 11) ? "Valid": "Invalid";
            Console.WriteLine(isValid);

            //t2
            var numberOne = 5;
            var numberTwo = 9;

            var whichIsGreater = (numberOne > numberTwo) ? numberOne : numberTwo;
            Console.WriteLine(whichIsGreater);

            //t3
            var width = 300;
            var height = 600;

            var isLandscape = (width > height) ? "Landscape" : "Portrait";
            Console.WriteLine(isLandscape);

            //t4
            const int speedLimit = 25;
            var carSpeed = 30;
            var fine = (carSpeed - speedLimit);

            if (fine > 0)
            {
                var points = (fine / 5);
                if(points > 12)
                    Console.WriteLine("Suspended");
                else
                    Console.WriteLine("You have got " + points + " points on your license.");
            } else
            {
                Console.WriteLine("No issues");
            }





        }   
    }
}
