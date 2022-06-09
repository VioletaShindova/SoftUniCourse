using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WeekendOrWorkingDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textDay = Console.ReadLine();

            if(textDay == "Monday")
            {
                Console.Write("Working day");
            }
            else if(textDay == "Tuesday")
            {
                Console.Write("Working day");
            }
            else if (textDay == "Wednesday")
            {
                Console.Write("Working day");
            }
            else if (textDay == "Thursday")
            {
                Console.Write("Working day");
            }
            else if (textDay == "Friday")
            {
                Console.Write("Working day");
            }
            else if(textDay == "Saturday")
            {
                Console.Write("Weekend");
            }
            else if (textDay == "Sunday")
            {
                Console.Write("Weekend");
            }
            else
            {
                Console.Write("Error");
            }
        }
    }
}
