﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {(int)number * i}");
            }
        }
    }
}
