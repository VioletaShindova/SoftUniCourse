using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int seriesDuration = int.Parse(Console.ReadLine()); 
            int restDuration = int.Parse(Console.ReadLine());

            double timeForLunch = restDuration * 1 / 8;
            double timeForRest = restDuration * 1 / 4;
            double timeLeft = restDuration - timeForLunch - timeForRest;

            if (timeLeft >= seriesDuration)
            {
                double leftMinutes = timeLeft - seriesDuration;
                Console.Write($"You have enough time to watch {seriesName:F0} and left with {leftMinutes} minutes free time.");    
            }
            else
            {
                double leftMinutes = seriesDuration - timeLeft;
                Console.Write($"You don't have enough time to watch {seriesName:F0}, you need {leftMinutes} more minutes.");
            }
        }
    }
}
