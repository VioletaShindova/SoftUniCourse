using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoArrays2
{
    internal class Program
    {
        static void InputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Input length of the arrays: ");
            uint arrayLength = uint.Parse(Console.ReadLine());

            int[] firstArray = new int[arrayLength];
            int[] secondArray = new int[arrayLength];
            int[] thirdArray = new int[arrayLength];

            Console.WriteLine("First array: ");
            InputArray(firstArray);
            Console.WriteLine("Second array: ");
            InputArray(secondArray);

            for (int i = 0; i < arrayLength; i++)
            {
                if(firstArray[i] > secondArray[i])
                {
                    thirdArray[i] = firstArray[i];
                }
                else
                {
                    thirdArray[i] = secondArray[i];
                }
            }

            Console.WriteLine("Third array:");

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(thirdArray[i] + " ");
            }
        }
    }
}
