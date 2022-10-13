using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint age = uint.Parse(Console.ReadLine());

            if (age >= 0 && age <= 2)
            {
                Console.WriteLine("baby");
            }
            if (age >= 3 && age <= 13)
            {
                Console.WriteLine("chil");
            }
            if (age >= 14 && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            if (age >= 20 && age <= 65)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
