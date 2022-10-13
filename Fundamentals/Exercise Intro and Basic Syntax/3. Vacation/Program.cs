using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint membersOfGroup = uint.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;

            if(typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    if (membersOfGroup >= 30)
                    {
                        price = (8.45 * membersOfGroup) - ((8.45 * membersOfGroup) * 0.15);

                    }
                    else
                    {
                        price = 8.45 * membersOfGroup;
                    }
                }
                else if (dayOfWeek == "Saturday")
                {
                    if (membersOfGroup >= 30)
                    {
                        price = (9.80 * membersOfGroup) - ((9.80 * membersOfGroup) * 0.15);
                    }
                    else
                    {
                        price = 9.80 * membersOfGroup;
                    }
                }
                else if (dayOfWeek == "Sunday")
                {
                    if (membersOfGroup >= 30)
                    {
                        price = (10.46 * membersOfGroup) - ((10.46 * membersOfGroup) * 0.15);
                    }
                    else
                    {
                        price = 10.46 * membersOfGroup;
                    }
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    if (membersOfGroup >= 100)
                    {
                        price = (10.90 * (membersOfGroup - 10));
                    }
                    else
                    {
                        price = 10.90 * membersOfGroup;
                    }
                }
                else if (dayOfWeek == "Saturday")
                {
                    if (membersOfGroup >= 100)
                    {
                        price = (15.60 * (membersOfGroup - 10));
                    }
                    else
                    {
                        price = 15.60 * membersOfGroup;
                    }
                }
                else if (dayOfWeek == "Sunday")
                {
                    if (membersOfGroup >= 100)
                    {
                        price = (16 * (membersOfGroup - 10));
                    }
                    else
                    {
                        price = 16 * membersOfGroup;
                    }
                }
            }
            if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    if (membersOfGroup >= 10 && membersOfGroup <= 20)
                    {
                        price = (15 * membersOfGroup) - ((15 * membersOfGroup) * 0.05);
                    }
                    else
                    {
                        price = 15 * membersOfGroup;
                    }
                }
                else if (dayOfWeek == "Saturday")
                {
                    if (membersOfGroup >= 10 && membersOfGroup <= 20)
                    {
                        price = (20 * membersOfGroup) - ((20 * membersOfGroup) * 0.05);
                    }
                    else
                    {
                        price = 20 * membersOfGroup;
                    }
                }
                else if (dayOfWeek == "Sunday")
                {
                    if (membersOfGroup >= 10 && membersOfGroup <= 20)
                    {
                        price = (22.50 * membersOfGroup) - ((22.50 * membersOfGroup) * 0.05);
                    }
                    else
                    {
                        price = 22.50 * membersOfGroup;
                    }
                }
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
