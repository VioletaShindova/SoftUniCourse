using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if(figure == "square")
            {
                double paramterersSquare = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Pow(paramterersSquare, 2));
            }
            else if(figure == "rechtangle")
            {
                double paramtererRechtangle = double.Parse(Console.ReadLine());
                double paramtererRechtangleLength = double.Parse(Console.ReadLine());

                Console.WriteLine(paramtererRechtangle * paramtererRechtangleLength);

            }
            else if(figure == "circle")
            {
                double paramterersCircle = double.Parse(Console.ReadLine()); //radius

                Console.WriteLine(Math.PI * Math.Pow(paramterersCircle, 2));

            }
            else if(figure == "triangle")
            {
                double paramterersTriangle = double.Parse(Console.ReadLine());
                double paramterersTriangleHeight = double.Parse(Console.ReadLine());

                Console.WriteLine((paramterersTriangle * paramterersTriangleHeight) / 2);
            }
        }
    }
}
