using System;

namespace FoodDelivery
{
    internal class Program
    {
        /// <summary>
        /// This method is for checking whether the entered number is between the min and max value.
        /// </summary>
        /// <param name="parameterName">The name of the parameter of the cube.</param>
        /// <param name="minValue">The min value. </param>
        /// <param name="maxValue">The max value.</param>
        /// <returns></returns>
        static uint checkForValue(string parameterName, uint minValue, uint maxValue)
        {
            uint parameter;
            do
            {
                Console.Write($"Enter the {parameterName} of the cube: ");
                parameter = uint.Parse(Console.ReadLine());
            } while ((parameter < minValue) || (parameter > maxValue));
            return parameter;
        }
        static double checkForProcentValue(string parameterName, double minValue, double maxValue)
        {
            uint parameter;
            do
            {
                Console.Write($"Enter the {parameterName} of the cube: ");
                parameter = uint.Parse(Console.ReadLine());
            } while ((parameter < minValue) || (parameter > maxValue));
            return parameter;
        }
        
        static void Main(string[] args)
        {
            
            //defined length 
            uint length;
            uint minValueLength = 10;
            uint maxValueLength = 500;
            string parameterLength = "length";

            length = checkForValue(parameterLength, minValueLength, maxValueLength);

            //defined width
            uint width;
            uint minValueWidth = 10;
            uint maxValueWidth = 300;
            string parameterWidth = "width";

            width = checkForValue(parameterWidth, minValueWidth, maxValueWidth);

            //defined height
            uint height;
            uint minValueHeight = 10;
            uint maxValueHeight = 200;
            string parameterHeigt = "height";

            height = checkForValue(parameterHeigt, minValueHeight, maxValueHeight);

            //defined procent
            double procent;
            double minValueProcent = 0.000;
            double maxValueProcent = 100.000;
            string parameterProcent = "procent";

            procent = checkForProcentValue(parameterProcent, minValueProcent, maxValueProcent);

            uint aquariumVolume = length * width * height;
            double volumeInLiters = (double)aquariumVolume / 1000;
            double takenSpace = procent / 100;
            double neededLiters = volumeInLiters * (1 - takenSpace);

            Console.Write("Needed liters are " + neededLiters);
            

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("The area is = " + (a * b));
        }
    }
}
