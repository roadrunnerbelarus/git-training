using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days: ");

            var input = Console.ReadLine();
            var futureDay = DateCalculator.AddFromToday(input);

            Console.WriteLine($"In {input} days from today there will be \n{futureDay.Day} {futureDay.ToString("MMM")} {futureDay.Year} {futureDay.DayOfWeek}");
            Console.ReadKey();
        }
    }
}
