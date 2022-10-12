using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int addedMinutes = 0;

            if ((minutes + 30) > 59)
            {
                if (hour >= 0 && hour < 23 && minutes >= 0 && minutes < 59)
                { 
                    hour++;
                    addedMinutes = (minutes + 30) - 60;
                }
                else
                {
                    hour = 0;
                    addedMinutes = (minutes + 30) - 60;
                }
            }
            else if ((minutes+30) <= 59)
            {
                addedMinutes = minutes + 30;
            }

            string hourText = "0" + hour;
            string otherMinutesText = "0" + addedMinutes;

            if (hour < 10)
            {
                if (addedMinutes < 10)
                {
                Console.WriteLine($"{hourText}:{otherMinutesText}");
                }
                else
                {
                    Console.WriteLine($"{hourText}:{addedMinutes}");
                }
            }
            else if (addedMinutes < 10)
            {
                Console.Write($"{hour}:{otherMinutesText}");
            }
            else
            {
                Console.Write($"{hour}:{addedMinutes}");

            }
        }
    }
}
