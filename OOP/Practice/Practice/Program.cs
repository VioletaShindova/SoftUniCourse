using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Student stud = new Student();

            Console.Write("Input math grade: ");
            stud.Math = double.Parse(Console.ReadLine());

            Console.Write("Input english grade: ");
            stud.English = double.Parse(Console.ReadLine());

            Console.Write("Input science grade: ");
            stud.Science = double.Parse(Console.ReadLine());

            double averageGrade = stud.CalcAverage(stud.Math, stud.English, stud.Science);

            stud.Spravka(stud.Math, stud.English, stud.Science, averageGrade);
        }
    }
}
