using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            if (firstTime >= 1 && firstTime <= 50 && secondTime >= 1 && secondTime <= 50 && thirdTime >= 1 && thirdTime <= 50)
            {
                int sumTime = firstTime + secondTime + thirdTime;

                int minutes = sumTime / 60;
                int seconds = sumTime % 60;

                if(seconds < 10)
                {
                    Console.WriteLine($"{minutes}:0{seconds}");
                }
                else
                {
                    Console.WriteLine($"{minutes}:{seconds}");
                }
            }
        }
    }
}
