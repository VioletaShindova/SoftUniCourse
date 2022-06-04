using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());

            double[] array = new double[n];

            Console.WriteLine("Enter the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(i%2 != 0)
                {
                    sum = sum + array[i];
                }
            }
            Console.WriteLine("The sum is " + sum);

            


            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[n, m];



            //for (int row = 0; row < m; row++)
            //{
            //    for (int col = 0; col < m; col++)
            //    {
            //        matrix[row, col] = int.Parse(Console.ReadLine());
            //    }
            //}



            //int min = matrix[0,0];

            //for(int row = 0; row < m; row++)
            //{
            //    for (int col = 0; col < m; col++)
            //    {
            //        if(matrix[row, col]<min)
            //        {
            //            min = matrix[row, col];
            //        }
            //    }
            //}

            //Console.WriteLine(min);

        }
    }
}
