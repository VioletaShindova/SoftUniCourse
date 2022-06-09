using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            decimal price;

            if(city == "Sofia")
            {
                if (product == "coffee")
                {
                    price = 0.50m * (decimal)amount;
                    Console.WriteLine(price);
                }
                else if (product == "water")
                {
                    price = 0.80m * (decimal)amount;
                    Console.WriteLine(price);
                }
                else if (product == "beer")
                {
                    price = 1.20m * (decimal)amount;
                    Console.WriteLine($"{price:F1}");
                }
                else if (product == "sweets")
                {
                    price = 1.45m * (decimal)amount;
                    Console.WriteLine($"{price:F4}");
                }
                else if (product == "peanuts")
                {
                    price = 1.60m * (decimal)amount;
                    Console.WriteLine(price);
                }
            }
            else if(city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.40m * (decimal)amount;
                    Console.WriteLine(price);
                }
                else if (product == "water")
                {
                    price = 0.70m * (decimal)amount;
                    Console.WriteLine($"{price:F1}");
                }
                else if (product == "beer")
                {
                    price = 1.15m * (decimal)amount;
                    Console.WriteLine(price);
                }
                else if (product == "sweets")
                {
                    price = 1.30m * (decimal)amount;
                    Console.WriteLine(price);
                }
                else if (product == "peanuts")
                {
                    price = 1.50m * (decimal)amount;
                    Console.WriteLine($"{price:F1}");
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    price = 0.45m * (decimal)amount;
                    Console.WriteLine($"{price:F1}");
                }
                else if (product == "water")
                {
                    price = 0.70m * (decimal)amount;
                    Console.WriteLine(price);
                }
                else if (product == "beer")
                {
                    price = 1.10m * (decimal)amount;
                    Console.WriteLine(price);
                }
                else if (product == "sweets")
                {
                    price = 1.35m * (decimal)amount;
                    Console.WriteLine(price);
                }
                else if (product == "peanuts")
                {
                    price = 1.55m * (decimal)amount;
                    Console.WriteLine(price);
                }
            }
        }
    }
}
