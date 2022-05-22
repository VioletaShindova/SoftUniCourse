using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant8
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad2 
            Console.Write("Enter the length of the matrix(row and columns): ");
            int n = int.Parse(Console.ReadLine());
            double[,] matrix = new double[n, n];

            Console.WriteLine("Enter the data for the matrix: ");
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The matrix: ");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"{matrix[row, column], 4}");
                }
                Console.WriteLine();
            }

            int numberOfZeroElements = 0;
            int counterZeroElements = 0;
            for(int row = 0; row<matrix.GetLength(0); row++)
            {
                if (matrix[row, n - 1 - row] == numberOfZeroElements)
                {
                    counterZeroElements++;
                }
            }
            Console.WriteLine("The number zero elements of the reversed diagonal is: " + counterZeroElements);

            double sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum = sum + matrix[row, n - 1 - row];
            }
            Console.WriteLine("The sum of the numbers of the reversed diagonal is: " + sum);
        }
    }
}
