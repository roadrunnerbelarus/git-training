using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days: ");
            var i = Int32.Parse(Console.ReadLine());

            var futureDay = DateCalculator.AddFromToday(i);

            Console.WriteLine($"In {i} days from today there will be \n{futureDay.Day} {futureDay.ToString("MMM")} {futureDay.Year}");
            Console.ReadKey();
        }
    }
}
