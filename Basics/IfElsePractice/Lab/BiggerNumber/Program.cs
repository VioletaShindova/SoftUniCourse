﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());

            if(firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }

            if (firstNumber < secondNumber)
            {
                Console.WriteLine(secondNumber);
            }
        }
    }
}
