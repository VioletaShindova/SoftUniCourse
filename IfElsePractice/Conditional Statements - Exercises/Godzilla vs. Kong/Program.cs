using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godzilla_vs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal decorPrice;
            decimal sumDecorAndClothingPrice;
            decimal sumPrice;

            Console.Write("Input budget for the film: ");
            decimal filmBudget = decimal.Parse(Console.ReadLine());

            if (filmBudget >= 1.00m && filmBudget <= 1000000.0m)
            {
                Console.Write("Input number of the statist people: ");
                uint numberStatistPeople = uint.Parse(Console.ReadLine());

                if (numberStatistPeople >= 1 && numberStatistPeople <= 500)
                {
                    Console.Write("Input price for working clothes: ");
                    decimal clothingPricePerOnePerson = decimal.Parse(Console.ReadLine());

                    if (clothingPricePerOnePerson >= 1.00m && clothingPricePerOnePerson <= 1000.0m)
                    {
                        decorPrice = filmBudget * 0.1m;
                        decimal sumForClothing = numberStatistPeople * clothingPricePerOnePerson;
                        sumDecorAndClothingPrice = decorPrice + sumForClothing;

                        if (numberStatistPeople > 150)
                        {
                            decimal discountForClothing = 0.1m * sumForClothing;
                            sumPrice = discountForClothing + decorPrice;

                            if (decorPrice > filmBudget && discountForClothing > filmBudget)
                            {
                                Console.WriteLine("Not enough money!");
                                Console.Write($"Wingard need {sumPrice - filmBudget} leva more.");
                            }
                            else
                            {
                                Console.WriteLine("Action!");
                                Console.Write($"Wingard starts filming with {filmBudget - sumPrice} leva left.");
                            }
                        }
                        else
                        {
                            if (decorPrice > filmBudget && sumForClothing > filmBudget)
                            {
                                Console.WriteLine("Not enough money!");
                                Console.Write($"Wingard need {sumDecorAndClothingPrice - filmBudget} leva more.");
                            }
                            else
                            {
                                Console.WriteLine("Action!");
                                Console.Write($"Wingard starts filming with {filmBudget - sumDecorAndClothingPrice} leva left.");
                            }
                        }
                    }
                }
            }
        }
    }
}
