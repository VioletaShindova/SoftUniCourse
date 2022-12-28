using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerEvenElement
{
    internal class Program
    {
        static void InputArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            return;
        }

        static void MultiplyingEachArrayElement(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0)
                {
                    array[i] = Math.Pow(array[i], 2);
                }
                else
                {
                    array[i] *= 2;
                }
            }
            return;
        }

        static void OutputArray(double[] array)
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

            double[] array = new double[arrayLength];

            InputArray(array);

            MultiplyingEachArrayElement(array);

            Console.WriteLine("Array: ");
            OutputArray(array);
        }
    }
}
