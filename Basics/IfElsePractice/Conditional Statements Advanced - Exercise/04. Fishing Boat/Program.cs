using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint groupBudget = uint.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            uint numberFishers = uint.Parse(Console.ReadLine());

            double discountPrice = 0;

            if (season == "Spring")
            {
                if (numberFishers <= 6)
                {
                    if (numberFishers % 2 == 0)
                    {
                        discountPrice = 3000 - (3000 * 0.15);
                    }
                    else
                    {
                        discountPrice = 3000 - (3000 * 0.1);
                    }
                }
                else if (numberFishers >= 7 && numberFishers <= 11)
                {
                    if (numberFishers % 2 == 0)
                    {
                        discountPrice = 3000 - (3000 * 0.2);
                    }
                    else
                    {
                        discountPrice = 3000 - (3000 * 0.15);
                    }
                }
                else if (numberFishers >= 12)
                {
                    if (numberFishers % 2 == 0)
                    {
                        discountPrice = 3000 - (3000 * 0.3);
                    }
                    else
                    {
                        discountPrice = 3000 - (3000 * 0.25);
                    }
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                if (numberFishers <= 6)
                {
                    if (numberFishers % 2 == 0 && season == "Summer")
                    {
                        discountPrice = 4200 - (4200 * 0.15);
                    }
                    else
                    {
                        discountPrice = 4200 -(4200 * 0.1);
                    }
                }
                else if (numberFishers >= 7 && numberFishers <= 11)
                {
                    if (numberFishers % 2 == 0 && season == "Summer")
                    {
                        discountPrice = 4200 - (4200 * 0.2);
                    }
                    else
                    { 
                        discountPrice = 4200 - (4200 * 0.15);
                    }
                }
                else if (numberFishers >= 12)
                {
                    if (numberFishers % 2 == 0 && season == "Summer")
                    {
                        discountPrice = 4200 - (4200* 0.3);
                    }
                    else
                    {
                        discountPrice = 4200 - (4200 * 0.25);
                    }
                }
            }
            else if (season == "Winter")
            {
                if (numberFishers <= 6)
                {
                    if (numberFishers % 2 == 0)
                    {
                        discountPrice = 2600 - (2600 * 0.15);
                    }
                    else
                    {
                        discountPrice = 2600 - (2600 * 0.1);
                    }
                }
                else if (numberFishers >= 7 && numberFishers <= 11)
                {
                    if (numberFishers % 2 == 0)
                    {
                        discountPrice = 2600 - (2600 * 0.2);
                    }
                    else
                    {
                        discountPrice = 2600 - (2600 * 0.15);
                    }
                }
                else if (numberFishers >= 12)
                {
                    if (numberFishers % 2 == 0)
                    {
                        discountPrice = 2600 - (2600 * 0.3);
                    }
                    else
                    {
                        discountPrice = 2600 - (2600 * 0.25);
                    }
                }
            }

            if(groupBudget >= discountPrice)
            {
                double finalPrice = groupBudget - discountPrice;
                Console.WriteLine($"Yes! You have {finalPrice:f2} leva left.");
            }
            else
            {
                double finalPrice = discountPrice - groupBudget;
                Console.WriteLine($"Not enough money! You need { finalPrice:f2} leva.");
            }
        }
    }
}
