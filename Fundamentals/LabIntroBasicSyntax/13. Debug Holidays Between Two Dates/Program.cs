using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Debug_Holidays_Between_Two_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd.m.yyyy", CultureInfo.InvariantCulture);

            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd.m.yyyy", CultureInfo.InvariantCulture);
            if (startDate.Month > endDate.Day || startDate.Month > endDate.Month || startDate.Year > endDate.Year)
            {

            }

            uint holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                { 
                    holidaysCount++;
                }
            }

            Console.WriteLine(holidaysCount);
        }
    }
}
