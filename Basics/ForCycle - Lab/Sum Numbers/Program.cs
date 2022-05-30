using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numbers;
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                numbers = int.Parse(Console.ReadLine());
                sum = sum + numbers;
            }
            Console.WriteLine(sum);
        }
    }
}
