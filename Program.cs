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
                Console.WriteLine(start.ToString("MMM", culture) + " (Single Month): " + daysInSingleMonth.ToString("00"));
            } else {
            var daysInFirstMonth = DateTime.DaysInMonth(start.Year, start.Month) - start.Day;
            Console.WriteLine(start.ToString("MMM", culture) + " (First Month): " + daysInFirstMonth.ToString("00"));  

            DateTime current = start.AddMonths(1);
            while (current <= end.AddMonths(-1))
            {
                var daysInCurrentMonth = DateTime.DaysInMonth(current.Year, current.Month);
                Console.WriteLine(current.ToString("MMM", culture) + ": " + daysInCurrentMonth.ToString("00")); 

                current = current.AddMonths(1);
            }

            var daysInLastMonth = end.Day;
            Console.WriteLine(end.ToString("MMM", culture) + " (Last Month): " + daysInLastMonth.ToString("00"));
        }
    }
}
