using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            const string savePass = "s3cr3t!P@ssw0rd";

            if(password == savePass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
