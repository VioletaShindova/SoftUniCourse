using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumberInTheArrayAndClass
{
    internal class Array
    {
        private int[] array;

        private int arraySize;

        public int ArraySize
        {
            set
            {
                this.arraySize = value;
            }
            get
            {
                return this.arraySize;
            }
        }

        //constructor with parameters
        public Array(int lengthOfTheArray)
        {
            this.ArraySize = lengthOfTheArray;
        }


        //--------------------------------------------------------------
        //needed copy constructor
        //--------------------------------------------------------------


        /// <summary>
        /// This method is supposed to find the biggest number from the array.
        /// </summary>
        /// <returns></returns>
        public int FindTheBiggestNumber()
        {
            this.array = new int[this.arraySize];

            Console.WriteLine("Input numbers for the array: ");
            InputNumbersForTheArray();

            Console.WriteLine("Array: ");
            //Array(array);
            OutputNumberFotTheArray();

            int maxNumberFromTheArray = 0;
            for(int index = 0; index < this.arraySize; index++)
            {
                if (this.array[index] >= -9 && this.array[index] < 10)
                {
                    if (maxNumberFromTheArray < this.array[index])
                    {
                        maxNumberFromTheArray = this.array[index];
                    }
                }
            }    
            return maxNumberFromTheArray;
        }

        /// <summary>
        /// This method is supposed to enter the numbers for the array.
        /// </summary>
        public void InputNumbersForTheArray()
        {
            for(int index = 0; index < this.arraySize; index++)
            {
                this.array[index] = int.Parse(Console.ReadLine());
            }
            return;
        }

        /// <summary>
        /// This method is supposed line the numbers of the array.
        /// </summary>
        public void OutputNumberFotTheArray()
        {
            for(int index = 0; index < this.arraySize; index++)
            {
                if(index == (this.arraySize - 1))
                {
                    Console.Write(this.array[index]);
                }
                else
                {
                    Console.Write(this.array[index] + ", ");
                }
            }
            return;
        }
    }
}
