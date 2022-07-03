using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOpenedBrowsers = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int salaryWithFine = 0;
            int salaryWithFineFacebook = 0;

            for (int i = 1; i <= numberOpenedBrowsers; i++)
            {
                string browser = Console.ReadLine();   

                if(browser == "Facebook")
                {
                    salaryWithFine = salary - 150;

                }
                else if(browser == "Instagram")
                {
                    salaryWithFine = salary - 100;
                }
                else if(browser == "Reddit")
                {
                    salaryWithFine = salary - 50;
                }
            }

            if(salaryWithFine <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salaryWithFine);
            }
        }
    }
}
