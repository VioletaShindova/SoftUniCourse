using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeProject = Console.ReadLine();

            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            const double pricePremiere = 12.00;
            const double priceNormal = 7.50;
            const double priceDiscount = 5.00;

            double price = 0;

            if (typeProject == "Premiere")
            {
                price = rows * columns * pricePremiere;
            }
            else if (typeProject == "Normal")
            {
                price = rows * columns * priceNormal;
            }
            else if (typeProject == "Discount")
            {
                price = rows * columns * priceDiscount;
            }

            Console.WriteLine($"{price:F2} leva");
            //Console.WriteLine("{0:F2} leva", price);
        }
    }
}
