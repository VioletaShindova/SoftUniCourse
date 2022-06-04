using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant2SingleAndMatrixArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //v2z1
            //Console.Write("Enter the length of both arrays: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] firstArray = new int[n];
            //int[] secondArray = new int[n];

            //Console.WriteLine("Enter the numbers of the first array: ");
            //for (int i = 0; i < firstArray.Length; i++)
            //{
            //    firstArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter the numbers of the second array: ");
            //for (int i =0; i<secondArray.Length; i++)
            //{
            //    secondArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Both arrays in one line: ");
            //for(int i = 0; i < firstArray.Length; i++)
            //{
            //    Console.Write($"{firstArray[i]}; ");
            //}

            //for(int i = 0; i < secondArray.Length; i++)
            //{
            //    Console.Write($"{secondArray[i]}; ");
            //}

            //int sum = 0;
            //for(int i = 0; i < n; i++)
            //{
            //    sum = sum + firstArray[i] * secondArray[i];
            //}
            //Console.WriteLine();
            //Console.Write("The sum is " + sum);

            //v2z1
            Console.Write("Enter the number of the rows: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the columns: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            Console.WriteLine("Enter the numbers of the matrix: ");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The matrix: ");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"{matrix[row, column],6}");
                }
                Console.WriteLine();
            }

            int counterOdd = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (matrix[row, column] % 2 != 0)
                    {
                        counterOdd++;
                    }
                }
            }
            Console.WriteLine("The odd numbers are: " + counterOdd);
        }
    }
}
