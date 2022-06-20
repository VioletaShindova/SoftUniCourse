using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint lillyAge = uint.Parse(Console.ReadLine());
            double washingMacninePrice = double.Parse(Console.ReadLine());
            double singleToyPrice = double.Parse(Console.ReadLine());

            int counterToys = 0;
            int counterYearsLillyGotMoney = 0;
            double moneyForBdays = 0;

            if (lillyAge <= 77 && lillyAge >= 1)
            {
                for (int i = 1; i <= 77; i++)
                {
                    if (i % 2 != 0)
                    {
                        counterToys++;
                    }
                    else if (i % 2 == 0)
                    {
                        counterYearsLillyGotMoney++;
                        moneyForBdays = moneyForBdays + 10.00;
                    }
                }
            }

            double allMoney = ((counterToys * singleToyPrice) + moneyForBdays) - counterYearsLillyGotMoney;

            if (washingMacninePrice > allMoney)
            {
                double neededMoney = washingMacninePrice - allMoney;
                Console.WriteLine($"No! {neededMoney:F2}");
            }
            else if (washingMacninePrice <= allMoney)
            {
                double neededMoney = allMoney - washingMacninePrice;
                Console.WriteLine($"No! {neededMoney:F2}");
            }
        }
    }
}
