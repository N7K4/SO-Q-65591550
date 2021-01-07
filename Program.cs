using System;
using System.Globalization;

namespace SO
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");

            DateTime start = new DateTime(2020, 1, 2); // 2 January 2020
            DateTime end = new DateTime(2020, 3, 4); // 4 March 2020

            if (start.Year == end.Year && start.Month == end.Month) {
                var daysInSingleMonth = end.Day - start.Day;
                log(start, culture, daysInSingleMonth, " (Single Month): ");
            } else {
                var daysInFirstMonth = DateTime.DaysInMonth(start.Year, start.Month) - start.Day;
                log(start, culture, daysInFirstMonth, " (First Month): ");

                DateTime current = start.AddMonths(1);
                while (current <= end.AddMonths(-1))
                {
                    var daysInCurrentMonth = DateTime.DaysInMonth(current.Year, current.Month);
                    log(current, culture, daysInCurrentMonth);

                    current = current.AddMonths(1);
                }

                var daysInLastMonth = end.Day;
                log(end, culture, daysInLastMonth, " (Last Month): ");
            }            
        }

        static void log(DateTime dt, IFormatProvider culture, int days, string sep = ": ") {
            Console.WriteLine(dt.ToString("MMM", culture) + sep + days.ToString("00")); 
        }
    }
}
