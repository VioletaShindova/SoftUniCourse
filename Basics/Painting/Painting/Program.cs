using System;

namespace Painting
{
    internal class Program
    {
        /*
        static uint GetNewAmount(string nameOfProduct, uint minValue, uint maxValue)
        {
            uint amount;

            do
            {
                Console.Write($"Enter amount of {nameOfProduct} in range {minValue} - {maxValue}: ");
                amount = uint.Parse(Console.ReadLine());
            }
            while ((minValue > amount) || (amount > maxValue));

            return amount;
        }
        */
        static void Main(string[] args)
        {
            /*
            const decimal nylonCostPerSquare = 1.50M;
            const decimal dyeCostPerLiter = 14.50M;
            const decimal diluentForDyePerLiter = 5.00M;
            const decimal bagPrice = 0.40M;
            const uint addedNylon = 2;

            //definition of nylon
            const string nylonProduct = "nylon";
            const uint minQuantityNylon = 1;
            const uint maxQuantityNylon = 100;

            //definition of dye
            const string dyeProduct = "dye";
            const uint minQuantityDye = 1;
            const uint maxQuantityDye = 100;

            //definition of diluent
            const string diluentProduct = "diluent";
            const uint minQuantityDiluent = 1;
            const uint maxQuantityDiluent = 30;

            //definition of hours
            const string hours = "hours";
            const uint minWorkingHours = 1;
            const uint maxWorkingHours = 9;


            uint amountOfNylon = GetNewAmount(nylonProduct, minQuantityNylon, maxQuantityNylon);
            uint amountOfDye = GetNewAmount(dyeProduct, minQuantityDye, maxQuantityDye);
            uint amountOfDiluent = GetNewAmount(diluentProduct, minQuantityDiluent, maxQuantityDiluent);
            uint workingHours = GetNewAmount(hours, minWorkingHours, maxWorkingHours);

            decimal nylonPrice = ((decimal)amountOfNylon + addedNylon) * nylonCostPerSquare;
            decimal dyePrice = (amountOfDye + (((decimal)10/100) * (decimal)amountOfDye)) * dyeCostPerLiter;
            decimal diluentPrice = ((decimal)amountOfDiluent * diluentForDyePerLiter);
            decimal sumPrice = nylonPrice + dyePrice + diluentPrice + bagPrice;
            decimal priceForHands = (sumPrice * (decimal)30/100) * workingHours;
            decimal wholeSum = (priceForHands + sumPrice);

            Console.Write($"The whole price is {wholeSum}.");
             */

            //-----------------------------------------------------------------------------
            //Second code with same function without using method
            
            const decimal nylonCostPerSquare = 1.50M;
            const decimal dyeCostPerLiter = 14.50M;
            const decimal diluentForDyePerLiter = 5.00M;
            const decimal bagPrice = 0.40M;
            const uint addedNylon = 2;

            Console.Write($"Enter amount of nylon: ");
            uint amountOfNylon = uint.Parse(Console.ReadLine());

            Console.Write($"Enter amount of dye: ");
            uint amountOfDye = uint.Parse(Console.ReadLine())
                ;
            Console.Write($"Enter amount of diluent: ");
            uint amountOfDiluent = uint.Parse(Console.ReadLine());

            Console.Write($"Enter working hours: ");
            uint workingHours = uint.Parse(Console.ReadLine());

            decimal nylonPrice = ((decimal)amountOfNylon + addedNylon) * nylonCostPerSquare;
            decimal dyePrice = (amountOfDye + (((decimal)10 / 100) * (decimal)amountOfDye)) * dyeCostPerLiter;
            decimal diluentPrice = ((decimal)amountOfDiluent * diluentForDyePerLiter);
            decimal sumPrice = nylonPrice + dyePrice + diluentPrice + bagPrice;
            decimal priceForHands = (sumPrice * (decimal)30 / 100) * workingHours;
            decimal wholeSum = (priceForHands + sumPrice);

            Console.Write($"The whole price is {wholeSum}.");
        }
    }
}
