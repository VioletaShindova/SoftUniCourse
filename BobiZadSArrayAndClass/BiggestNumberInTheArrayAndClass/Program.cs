using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumberInTheArrayAndClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input length of the array: ");
            int lengthOfTheArray = int.Parse(Console.ReadLine());

            Array array = new Array(lengthOfTheArray);

            int biggestNumber = array.FindTheBiggestNumber();

            Console.WriteLine();

            Console.WriteLine($"The biggest number is {biggestNumber}");
        }
    }
}
