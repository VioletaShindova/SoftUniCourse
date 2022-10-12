using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;

                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
