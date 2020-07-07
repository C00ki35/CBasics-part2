
using System;

namespace CBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime display
            var dateTime = new DateTime(2020, 07, 07);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            var twentyMintuesAgo = now.AddMinutes(-20);

            Console.WriteLine(twentyMintuesAgo);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToString("yy-MM-dd HH:mm"));

            //Time Span

            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(5);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            //Subtract
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(8)
            Console.WriteLine("ToString" + timeSpan);
        }
    }
}
 
    
