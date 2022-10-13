using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int divisibleNumber = 2;

            for(int i = 1; i <= 5; i++)
            {
                if (number % 10 == 0)
                {
                    divisibleNumber = 10;
                    break;
                }
                else if (number % 7 == 0)
                {
                    divisibleNumber = 7;
                    break;
                }
                else if (number % 6 == 0)
                {
                    divisibleNumber = 6;
                    break;
                }
                else if (number % 3 == 0)
                {
                    divisibleNumber = 3;
                    break;
                }
                else if (number % 2 == 0)
                {
                    divisibleNumber = 2;
                    break;
                }
            }

            Console.WriteLine(divisibleNumber);
        }
    }
}
