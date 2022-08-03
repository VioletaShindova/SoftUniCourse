using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string stayIn = "";

            double price = 0;

            if(budget <= 100)
            {
                destination = "Bulgaria";

                if(season == "summer")
                {
                    stayIn = "Camp";

                    price = (budget * 0.3);
                }
                else
                {
                    stayIn = "Hotel";

                    price = (budget * 0.7);
                }
            }
            else if(budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    stayIn = "Camp";

                    price = (budget * 0.4);
                }
                else
                {
                    stayIn = "Hotel";

                    price = (budget * 0.8);
                }
            }
            else
            {
                destination = "Europe";

                stayIn = "Hotel";

                price = (budget * 0.9);
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.Write($"{stayIn} - {price:f2}");
        }
    }
}
