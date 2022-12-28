using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxArrayElement
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

        static double MaxArrayElement(double[] array)
        {
            /*double maxEelement = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[0])
                { 
                    maxEelement = array[i];
                }
            }*/

            return array.Max();
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

            double maxEelement = MaxArrayElement(array);

            Console.WriteLine("Array: ");
            OutputArray(array);

            Console.WriteLine();

            Console.WriteLine("Max element is: " + maxEelement);
        }
    }
}
