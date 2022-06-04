using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRedicaNumbersFrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for(int i = 0; i<array.Length; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine()); //pri index 0(i) enter a number
            //}
            //int counterX = 0;
            //int counterY = 0;

            //for(int i = 0; i < array.Length; i++)
            //{
            //    if(array[i] == x)
            //    {
            //        counterX++;
            //    }
            //    else if(array[i] == y)
            //    {
            //        counterY++;
            //    }
            //}
            //Console.WriteLine(counterX + " " + counterY);

            //for(int i = 0; i<array.Length; i++) //output
            //{
            //    Console.WriteLine(array[i] + ", ");
            //}

            //--------
            int m = int.Parse(Console.ReadLine());
            double[,] matrix = new double[m, m];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column<matrix.GetLength(1); column++)
                {
                    matrix[row, column] = double.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"{matrix[row,column], 4}");
                }
                Console.WriteLine();
            }

            //obraten diagonal, vtorichen
            double sum1 = 0;
            for(int row=0; row<matrix.GetLength(0); row++)
            {
                    sum1 = sum1 + matrix[row, m - 1 - row];
            }
            Console.Write(sum1 / m);

            double sum2 = 0; 
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum2 = sum2 + matrix[i, i];
            }
            Console.Write(sum2 / m);

        }
    }
}
