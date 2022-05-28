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
            //zad1
            Console.Write("Number of students: ");
            int x = int.Parse(Console.ReadLine()); //

            Console.Write("Enter the points: ");
            int points = int.Parse(Console.ReadLine());

            int[] array = new int[x];

            Console.WriteLine("Enter the grades of the test.");
            for(int i = 0; i<array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            
            //Check for points
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == points)
                {
                    Console.WriteLine("True and the index is " + i + ".");
                }
                else
                {
                    Console.WriteLine("False.");
                }
            }
            
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
