using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSide = n;
            int rightSide = n;

            int sumLeftSide = 0;
            int sumRightSide = 0;

            for(int i = 1; i <= leftSide; i++)
            {
                int numbersLeftSide = int.Parse(Console.ReadLine());
                sumLeftSide = sumLeftSide + numbersLeftSide;
            }
            Console.WriteLine();

            for (int i = 1; i <= rightSide; i++)
            {
                int numbersRightSide = int.Parse(Console.ReadLine());
                sumRightSide = sumRightSide + numbersRightSide;
            }

            if(sumLeftSide == sumRightSide)
            {
                Console.Write("Yes, sum = " + sumLeftSide);
            }
            else if(sumLeftSide > sumRightSide)
            {
                int sumDiff = sumLeftSide - sumRightSide;
                Console.Write("No, diff = " + sumDiff);
            }
            else
            {
                int sumDiff = sumRightSide - sumLeftSide;
                Console.Write("No, diff = " + sumDiff);
            }
        }
    }
}
