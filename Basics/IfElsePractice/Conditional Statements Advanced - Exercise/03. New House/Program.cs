using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerSpecies = Console.ReadLine();
            uint numberFlowers = uint.Parse(Console.ReadLine());
            int budged = int.Parse(Console.ReadLine());

            const double priceRose = 5;
            const double priceDahlia = 3.80;
            const double priceTulip = 2.80;
            const double priceNarcissus = 3;
            const double priceGladiola = 2.50;

            double price = 0;

            if (flowerSpecies == "Roses")
            {
                if (numberFlowers <= 80)
                {
                    price = numberFlowers * priceRose;
                }
                else if (numberFlowers > 80)
                {
                    price = (numberFlowers * priceRose) * 0.1;
                }
            }
            else if (flowerSpecies == "Dahlia")
            {
                if (numberFlowers <= 90)
                {
                    price = numberFlowers * priceDahlia;
                }
                else if (numberFlowers > 90)
                {
                    price = (numberFlowers * priceDahlia) * 0.15;
                }
            }
            else if (flowerSpecies == "Tulip")
            {
                if (numberFlowers <= 80)
                {
                    price = numberFlowers * priceTulip;
                }
                else if (numberFlowers > 80)
                {
                    price = (numberFlowers * priceTulip) * 0.15;
                }
            }
            else if (flowerSpecies == "Narcissus")
            {
                if (numberFlowers >= 120)
                {
                    price = numberFlowers * priceNarcissus;
                }
                else if (numberFlowers < 120)
                {
                    price = (numberFlowers * priceNarcissus) + ((numberFlowers * priceNarcissus) * 0.15);
                }
            }
            else if (flowerSpecies == "Gladiola")
            {
                if (numberFlowers >= 80)
                {
                    price = numberFlowers * priceGladiola;
                }
                else if (numberFlowers < 80)
                {
                    price = (numberFlowers * priceGladiola) + ((numberFlowers * priceGladiola) * 0.20);
                }
            }

            if (price <= budged)
            {
                double realPrice = budged - price;
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flowerSpecies} and {realPrice:f2} leva left.");
            }
            else
            {
                double realPrice = price - budged;
                Console.WriteLine($"Not enough money, you need {realPrice:f2} leva more.");
            }
        }
    }
}
