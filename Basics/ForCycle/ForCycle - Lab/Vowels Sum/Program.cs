using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char a = 'a';
            char e = 'e';
            char i = 'i';
            char o = 'o';
            char u = 'u';

            int sum = 0;

            for (int index = 0; index < text.Length; index++)
            {
                if(text[index] == a)
                {
                    sum = sum + 1;
                }
                else if(text[index] == e)
                {
                    sum = sum + 2;
                }
                else if(text[index] == i)
                {
                    sum = sum + 3;
                }
                else if(text[index] == o)
                {
                    sum = sum + 4;
                }
                else if(text[index] == u)
                {
                    sum = sum + 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
