using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());

            if(recordInSeconds >= 0.00 && recordInSeconds <= 100000.00)
            {
                double lengthInMeters = double.Parse(Console.ReadLine());

                if(lengthInMeters >= 0.00 && lengthInMeters <= 100000.00)
                {
                    double timePerMeter = double.Parse(Console.ReadLine());

                    if(timePerMeter >= 0.00 && timePerMeter <= 1000.0)
                    {
                        double secondsForTheMeters = lengthInMeters * timePerMeter;

                        double cooldownTime = (lengthInMeters / 15) * 12.5;

                        double sumTime = (secondsForTheMeters + cooldownTime);

                        if(recordInSeconds < sumTime)
                        {
                            Console.Write($"No, he failed! He was {(sumTime - recordInSeconds):F2} seconds slower.");
                        }
                        else
                        {
                            Console.Write($" Yes, he succeeded! The new world record is {sumTime:F2} seconds.");
                        }
                    }
                }
            }
        }
    }
}
