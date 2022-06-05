using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());

            char gender = char.Parse(Console.ReadLine());

            if(age >= 16 && gender == 'm')
            {
                Console.Write("Mr.");
            }
            else if (age < 16 && gender == 'm')
            {
                Console.Write("Master");
            }
            else if (age >= 16 && gender == 'f')
            {
                Console.Write("Ms.");
            }
            else if (age < 16 && gender == 'f')
            {
                Console.Write("Miss");
            }
        }
    }
}
