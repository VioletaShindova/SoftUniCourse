using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingForANumber
{
    internal class Program
    {
        static bool CheckNumber(int a, int b, int number)
        {
            
            if(number>=a && number<=b || number>=b && number<=a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());

            string text;
            int sum;
            int number;
            int br = 0;

            do
            {
                text = Console.ReadLine();
                if (text == "stop")
                {
                    break;
                }
                else
                {
                    Console.Write("Input number = ");
                    number = int.Parse(text);
                }

                if (CheckNumber(a, b, number))
                {
                    sum += number;
                    br++;
                }
            }
            while (text != "stop");
        }
    }
}
