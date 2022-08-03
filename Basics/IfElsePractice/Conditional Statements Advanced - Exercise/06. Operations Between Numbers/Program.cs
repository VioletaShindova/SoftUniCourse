using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint firstNumber = uint.Parse(Console.ReadLine());
            uint secondNumber = uint.Parse(Console.ReadLine());

            char operatorr = char.Parse(Console.ReadLine());

            double result = 0;

            string checkOddEven = "";

            if (operatorr == '/')
            {
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
            }
            else if (operatorr == '*')
            {
                result = firstNumber * secondNumber;

                if (result % 2 == 0)
                {
                    checkOddEven = "even";
                }
                else
                {
                    checkOddEven = "odd";
                }

                Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - {checkOddEven}");
            }
            else if (operatorr == '+')
            {
                result = firstNumber + secondNumber;

                if(result%2 == 0)
                {
                    checkOddEven = "even";
                }
                else
                {
                    checkOddEven = "odd";
                }

                Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - {checkOddEven}");
            }
            else if (operatorr == '-')
            {
                result = firstNumber - secondNumber;

                if (result % 2 == 0)
                {
                    checkOddEven = "even";
                }
                else
                {
                    checkOddEven = "odd";
                }

                Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - {checkOddEven}");
            }
            else
            {
                if (secondNumber != 0)
                {
                    result = firstNumber % secondNumber;
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
            }
        }
    }
}
