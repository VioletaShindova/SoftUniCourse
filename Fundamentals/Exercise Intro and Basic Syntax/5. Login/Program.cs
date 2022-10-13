using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password;
            int count = -1;
            
            do
            {
                password = Console.ReadLine();
                int iP = password.Length - 1;

                if (username.Length == password.Length)
                {
                    for (int iU = 0; iU < username.Length; iU++)
                    {
                        for (iP = (password.Length - 1); iP >= 0; iP--)
                        {
                            //still need to work 
                            if (username[iU-1] >= 0)
                            {
                                if (username[iU] == password[iP])
                                {
                                    count++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (username[iU] == password[iP])
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }

                    }
                }

                if(count != username.Length)
                {
                    Console.WriteLine("Incorrect password.Try again.");
                }


            } while (count != username.Length);

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
