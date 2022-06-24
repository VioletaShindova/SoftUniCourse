using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 + ( 2 - (2 + 3) * 4 / (3 + 1)) * 5
            string inputMath = Console.ReadLine();

            int indexOpenBracket = -1;
            int indexCloseBracket = -1;

            int countOpenBracket = 0;

            for(int i = 0; i < inputMath.Length; i++)
            {
                //string element = inputMath[i].ToString();
                if (inputMath[i] == '(')
                {
                    countOpenBracket++;
                }
                else if (i == 0 && inputMath[i] == ')' || countOpenBracket == 0 && inputMath[i] == ')')
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    continue;
                }
            }

            for (int numberOfBrackets = 1; numberOfBrackets <= countOpenBracket; numberOfBrackets++)
            {
                for (int index = 0; index < inputMath.Length; index++)
                {
                    string element = inputMath[index].ToString();

                    if (index == indexOpenBracket)
                    {
                        continue;
                    }
                    else if (index == indexCloseBracket)
                    {
                        continue;
                    }
                    //if()
                    else if (element == "(")
                    {
                        indexOpenBracket = index;
                        continue;
                    }
                    else if (element == ")")
                    {
                        indexCloseBracket = index;
                        break;
                    }
                }
                for (int i = indexOpenBracket; i <= indexCloseBracket; i++)
                {
                    Console.Write(inputMath[i] + "");
                }
                Console.WriteLine();
            }
        }
    }
}
