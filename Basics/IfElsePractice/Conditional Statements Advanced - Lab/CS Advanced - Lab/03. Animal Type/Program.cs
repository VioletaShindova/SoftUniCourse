using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animal_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch(animal)
            {
                case "dog":
                    Console.Write("mammal");
                    break;
                case "snake":
                case "crocodile":
                case "tortoise":
                    Console.Write("reptile");
                    break;
                default:
                    Console.Write("unknown");
                    break;
            }
        }
    }
}
