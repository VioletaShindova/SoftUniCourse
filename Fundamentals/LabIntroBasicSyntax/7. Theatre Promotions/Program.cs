﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Theatre_Promotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //last moment saw the holiday situation

            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int counter = 0;
            int price = 0;

            if (day == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
            }
            if (age >= 0 && age <= 18 || age > 64 && age <= 122)
            {
                if (day == "Weekday")
                {
                    price = 12;
                }
                else if (day == "Weekend")
                {
                    price = 15;
                }
            }
            else if (age < 0)
            {
                Console.WriteLine("Error!");
                counter++;
            }
            else
            {
                if (day == "Weekday")
                {
                    price = 18;
                }
                else if (day == "Weekend")
                {
                    price = 20;
                }
                else if (day == "Weekend")
                {
                    price = 12;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine(price + "$");
            }
        }
    }
}
