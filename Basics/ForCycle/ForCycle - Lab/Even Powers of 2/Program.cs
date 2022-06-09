using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                for (int i = 0; i <= n; i += 2)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }

            else
            {
                for (int i = 0; i < n; i += 2)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
        }
    }
}
