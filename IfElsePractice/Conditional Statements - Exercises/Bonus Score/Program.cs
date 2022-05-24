using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint numberPoints = uint.Parse(Console.ReadLine());

            double bonusPoints;

            if(numberPoints <= 100)
            {
                bonusPoints = 5;
            }
            else if(numberPoints > 100 && numberPoints <= 1000)
            {
                bonusPoints = numberPoints * 0.2;
            }
            else
            {
                bonusPoints = numberPoints * 0.1;
            }

            if(numberPoints % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if(numberPoints % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints+numberPoints);
        }
    }
}
