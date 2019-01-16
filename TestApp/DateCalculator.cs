using System;

namespace TestApp
{
    public static class DateCalculator
    {
        internal static DateTime AddFromToday(string s)
        {
            int i = Int32.Parse(s);
            var today = DateTime.Now;
            return today.AddDays(i);
        }
    }
}
