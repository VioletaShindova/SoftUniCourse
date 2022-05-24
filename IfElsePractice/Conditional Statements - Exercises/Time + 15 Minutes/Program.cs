using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint hours = uint.Parse(Console.ReadLine());

            uint minutes = uint.Parse(Console.ReadLine());

            const uint added15Minutes = 15;

            uint addedMinutes;

            if(hours >= 0 && hours <= 24 && minutes >= 0 && minutes <= 60)
            {
                addedMinutes = minutes + added15Minutes;

                if(addedMinutes > 59)
                {
                    hours++;
                    addedMinutes = addedMinutes - 60;

                    if (hours < 24)
                    {
                        if (addedMinutes < 10)
                        {
                            Console.WriteLine($"{hours}:0{addedMinutes}");
                        }
                        else
                        {
                            Console.WriteLine($"{hours}:{addedMinutes}");
                        }
                    }
                    else
                    {
                        if (addedMinutes < 10)
                        {
                            Console.WriteLine($"0:0{addedMinutes}");
                        }
                        else
                        {
                            Console.WriteLine($"0:{addedMinutes}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{hours}:{addedMinutes}");
                }
            }
        }
    }
}
