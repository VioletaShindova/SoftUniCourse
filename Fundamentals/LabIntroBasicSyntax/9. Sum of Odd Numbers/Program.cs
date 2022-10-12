using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= (n + 2); i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);  
                    sum = sum + i;
                }
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
