using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyingEachElement
{
    internal class Program
    {
        static void InputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return;
        }

        static void MultiplyingEachArrayElement(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * 3;
            }
        }

        static void OutputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Input length of the array: ");
            uint arrayLength = uint.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            InputArray(array);

            MultiplyingEachArrayElement(array);

            Console.WriteLine("Array: ");
            OutputArray(array);
        }
    }
}
