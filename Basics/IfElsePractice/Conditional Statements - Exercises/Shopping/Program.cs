using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal priceVideoCard = 250m;
            //const decimal priceProcesor = 0.3;

            decimal budgetPeter = decimal.Parse(Console.ReadLine());
            int numberVideoCards = int.Parse(Console.ReadLine());
            int numberProcesors = int.Parse(Console.ReadLine());
            int RAM = int.Parse(Console.ReadLine());

            decimal sumVideoCards = numberVideoCards * priceVideoCard;
            decimal sumProcesor = (0.35m * sumVideoCards) * numberProcesors;
            decimal sumRAM = (0.1m * sumVideoCards) * RAM;
            decimal wholePrice = sumVideoCards + sumProcesor + sumRAM;

            if (numberVideoCards > numberProcesors)
            {
                decimal priceWithDiscout = wholePrice - (0.15m * wholePrice);
                
                if (budgetPeter >= priceWithDiscout)
                {
                    decimal moneyLeft = budgetPeter - priceWithDiscout;
                    Console.Write($"You have {moneyLeft:F2} leva left!");
                }
                //if (priceWithDiscout > budgetPeter)
                else 
                {
                    decimal moneyLeft = (priceWithDiscout - budgetPeter);
                    Console.Write($"Not enough money! You need {moneyLeft:F2} leva more!");
                }
            }
        }
    }
}
