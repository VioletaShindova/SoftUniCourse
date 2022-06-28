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
            double moneySaved = 0;

            for (int i = 1; i <= lillyAge; i++)
            {
                if (i % 2 != 0)
                {
                    counterToys++;
                }
                else if (i % 2 == 0)
                {
                    counterYearsLillyGotMoney++;
                    moneyForBdays = moneyForBdays + 10.00;
                    moneySaved = moneyForBdays;
                }
            }

            //double moneySaved = counterYearsLillyGotMoney * 
            //double allMoney = ((counterToys * singleToyPrice) + moneyForBdays) - counterYearsLillyGotMoney;
            
            moneySaved += moneyForBdays;
            double moneyToys = counterToys * singleToyPrice;
            double takenMoney = counterYearsLillyGotMoney * 1;

            double allMoney = moneySaved + moneyToys - takenMoney;

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
