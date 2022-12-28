using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumberArray
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

        static void ArrayEvenElement(int[] array, uint arrayLength)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else if (i == (array.Length - 1))
                {
                    continue;
                }
                else if (array[i] % 2 == 0)
                {
                    array[i] = array[0] + array[i];
                }
                else
                {
                    array[i] = array[arrayLength] + array[i];
                }
            }
            return;
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

            ArrayEvenElement(array, arrayLength-1);

            Console.WriteLine("Array: ");
            OutputArray(array);
        }
    }
}
