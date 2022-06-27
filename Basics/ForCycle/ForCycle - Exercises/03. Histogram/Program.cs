using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1;
            double p2;
            double p3;
            double p4;
            double p5;

            int numbers;

            uint counterLess200Nums = 0;
            uint counterBetween200And399 = 0;
            uint counterBetween400And599 = 0;
            uint counterBetween600And799 = 0;
            uint countet800Plus = 0;

            for (int i = 1; i <= n; i++)
            {
                numbers = int.Parse(Console.ReadLine());

                if (numbers < 200)
                {
                    counterLess200Nums++;
                }
                else if (numbers >= 200 && numbers <= 399)
                {
                    counterBetween200And399++;
                }
                else if (numbers >= 400 && numbers <= 599)
                {
                    counterBetween400And599++;
                }
                else if (numbers >= 600 && numbers <= 799)
                {
                    counterBetween600And799++;
                }
                else if (numbers >= 800)
                {
                    countet800Plus++;
                }
            }


            p1 = ((double)counterLess200Nums / n * 100);
            p2 = ((double)counterBetween200And399 / n * 100 * 1.0);
            p3 = (((double)counterBetween400And599 / n) * 100);
            p4 = (((double)counterBetween600And799 / n) * 100);
            p5 = (((double)countet800Plus / n) * 100);

            //double sumPercentages = p1 + p2 + p3 + p4+ p5;
            //ouble percentagep1 = sumPercentages - p2 - p3 - p4 - p5;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
