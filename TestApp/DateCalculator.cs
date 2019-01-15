using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
