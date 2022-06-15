using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxValue = int.MinValue;

            for (int i = 1; i <= numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;

                if (num > maxValue)
                {
                    maxValue = num;
                }
            }

            int sumWithoutMaxNumber = sum - maxValue;

            if (maxValue == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxValue);
            }
            else
            {
                int diff = Math.Abs(maxValue - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
