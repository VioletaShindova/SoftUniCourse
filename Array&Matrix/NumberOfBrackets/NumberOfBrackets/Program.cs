using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
         Да се напише програма, която определя дали дадена последователност от скоби е правилна. Примери: 

            правилно записани скоби:  (), ([]){}, ()[], (({})),

            неправилно записани:  )(, (])({), (, )})), ((())].
             */
            Stack<char> st = new Stack<char>();

            string input = Console.ReadLine();

            char symbol = ' ';
            bool isOk = true;

            for (int i = 0; i < input.Length; i++)
            {
                symbol = input[i];
                if (st.Count != 0)
                {
                    if (symbol == '}' || symbol == ')' || symbol == ']')
                    {
                        st.Pop();
                    }
                }
                else if (symbol == '}' || symbol == ')' || symbol == ']')
                {
                    st.Pop();
                }
                else if (symbol == '{' || symbol == '(' || symbol == '[')
                {
                    st.Push(symbol);
                }
            }
        }
    }
}
