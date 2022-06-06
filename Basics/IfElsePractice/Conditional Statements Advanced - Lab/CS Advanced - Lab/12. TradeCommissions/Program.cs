using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            decimal commission;

            if (city == "Sofia")
            {
                if (amount >= 0 && amount <= 500)
                {
                    commission = (decimal)amount * 0.05m;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (amount > 500 && amount <= 1000)
                {
                    commission = (decimal)amount * 0.07m;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (amount > 1000 && amount <= 10000)
                {
                    commission = (decimal)amount * 0.08m;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (amount > 10000)
                {
                    commission = (decimal)amount * 0.12m;
                    Console.WriteLine($"{commission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna ")
            {
                if (amount >= 0 && amount <= 500)
                {
                    commission = (decimal)amount * 0.45m;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (amount > 500 && amount <= 1000)
                {
                    commission = (decimal)amount * 0.75m;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (amount > 1000 && amount <= 10000)
                {
                    commission = (decimal)amount * 0.1m;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (amount > 10000)
                {
                    commission = (decimal)amount * 0.13m;
                    Console.WriteLine($"{commission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (amount >= 0 && amount <= 500)
                {
                    commission = (decimal)amount * 0.55m;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (amount > 500 && amount <= 1000)
                {
                    commission = (decimal)amount * 0.8m;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (amount > 1000 && amount <= 10000)
                {
                    commission = (decimal)amount * 0.12m;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (amount > 10000)
                {
                    commission = (decimal)amount * 0.145m;
                    Console.WriteLine($"{commission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
