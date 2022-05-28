using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterAndTheAreaOfSquare
{
    internal class Program
    {
        static void GettingS(double a, ref double S)
        {
            S = Math.Pow(a, 2);
        }
        static void GettingP(double a, ref double P)
        {
            P = 4 * a;
        }
        static void Main(string[] args)
        {
            {
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());

                double S = 0;
                double P = 0;

                GettingS(a, ref S);
                GettingP(a, ref P);
                Console.WriteLine($"S = {S}");
                Console.Write($"P = {P}");
            }
        }
    }
}
