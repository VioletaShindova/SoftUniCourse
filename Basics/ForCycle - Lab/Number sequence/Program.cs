using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            int min = 0;
            int max = 0; 
            
            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < min)
                {
                    min = number;
                }
                else if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max number: " + max);
            Console.WriteLine("Min number: " + min);
        }
    }
}
