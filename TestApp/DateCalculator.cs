using System;

namespace TestApp
{
    public static class DateCalculator
    {
        internal static DateTime AddFromToday(int i)
        {
            var today = DateTime.Now;
            return today.AddDays(i);
        }
    }
}
