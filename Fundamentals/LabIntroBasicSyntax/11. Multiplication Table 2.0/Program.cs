using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint starterNumber = uint.Parse(Console.ReadLine());

            for(uint i = starterNumber; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number*i}");
            }
        }
    }
}
