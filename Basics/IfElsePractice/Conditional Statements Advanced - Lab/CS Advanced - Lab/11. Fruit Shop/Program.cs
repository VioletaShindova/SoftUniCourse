using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            decimal price;

            if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.70m * (decimal)amount;
                    Console.Write($"{price:F2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.25m * (decimal)amount;
                    Console.Write($"{price:F2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.90m * (decimal)amount;
                    Console.Write(price);
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60m * (decimal)amount;
                    Console.Write($"{price:F2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00m * (decimal)amount;
                    Console.Write($"{price:F2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.70m * (decimal)amount;
                    Console.Write($"{price:F2}");
                }
                else if (fruit == "grapes")
                {
                    price = 4.20m * (decimal)amount;
                    Console.Write($"{price:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    price = 2.50m * (decimal)amount;
                    Console.Write($"{price:F2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.20m * (decimal)amount;
                    Console.Write($"{price:F2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.85m * (decimal)amount;
                    Console.Write($"{price:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45m * (decimal)amount;
                    Console.Write($"{price:F2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70m * (decimal)amount;
                    Console.Write($"{price:F2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50m * (decimal)amount;
                    Console.Write($"{price:F2}");
                }
                else if (fruit == "grapes")
                {
                    price = 3.85m * (decimal)amount;
                    Console.Write($"{price:F2}");
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
