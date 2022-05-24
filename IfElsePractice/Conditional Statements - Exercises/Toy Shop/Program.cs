using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //prices declaration
            const decimal puzzle = 2.6m;
            const decimal speakingDoll = 3.0m;
            const decimal teddyBear = 4.1m;
            const decimal minion = 8.2m;
            const decimal car = 2.0m;

            uint allToys;
            decimal discountPrice;
            decimal price;
            decimal priceWithDiscount;
            decimal rent;
            decimal profit;

            Console.Write("Input price of the vacation: ");
            decimal priceOfTheVacation = decimal.Parse(Console.ReadLine());

            if(priceOfTheVacation >= 1.0m && priceOfTheVacation <= 10000.0m)
            {
                Console.Write("Input number of puzzles: ");
                uint numberPuzzles = uint.Parse(Console.ReadLine());

                if(numberPuzzles>=0 && numberPuzzles<=1000)
                {
                    Console.Write("Input number of speaking dolls: ");
                    uint numberSpeakingDolls = uint.Parse(Console.ReadLine());

                    if (numberSpeakingDolls >= 0 && numberSpeakingDolls <= 1000)
                    {
                        Console.Write("Input number of teddy bears: ");
                        uint numberTeddyBears = uint.Parse(Console.ReadLine());

                        if (numberTeddyBears >= 0 && numberTeddyBears <= 1000)
                        {
                            Console.Write("Input number of minions: ");
                            uint numberMinions = uint.Parse(Console.ReadLine());
                           
                            if (numberMinions >= 0 && numberMinions <= 1000)
                            {
                                Console.Write("Input number of cars: ");
                                uint numberCars = uint.Parse(Console.ReadLine());

                                if (numberCars >= 0 && numberCars <= 1000)
                                {
                                    allToys = numberPuzzles + numberSpeakingDolls + numberTeddyBears + numberMinions + numberCars;

                                    price = numberPuzzles * puzzle + numberSpeakingDolls * speakingDoll + numberTeddyBears * teddyBear + numberMinions * minion + numberCars * car;

                                    if (allToys >= 50)
                                    {
                                        discountPrice = price * 0.25m;
                                        priceWithDiscount = price - discountPrice;
                                        rent = priceWithDiscount * 0.1m;
                                        profit = priceWithDiscount- rent;

                                        decimal moneyLeft = profit - priceOfTheVacation;

                                        if(profit > priceOfTheVacation)
                                        {
                                            Console.WriteLine($"Yes! {moneyLeft} lv left.");
                                        }
                                        else if(profit < priceOfTheVacation)
                                        {
                                            Console.WriteLine($"Not enough money! {moneyLeft} lv needed.");
                                        } 
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
