using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            int sumEven = 0;
            int sumOdd = 0; 

            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven = sumEven + array[i];
                }
                else
                {
                    sumOdd = sumOdd + array[i];
                }
            }

            if(sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumEven);
            }
            else if(sumEven > sumOdd)
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + (sumEven - sumOdd));
            }
            else if (sumEven < sumOdd)
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + (sumOdd - sumEven));
            }
        }
    }
}
