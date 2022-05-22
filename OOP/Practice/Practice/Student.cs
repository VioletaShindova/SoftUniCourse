using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Student
    {
        double math;
        double english;
        double science;

        public double CalcAverage(double subject1, double subject2, double subject3)
        {
            return (subject1 + subject2 + subject3) / 3;
        }
        public void Spravka (double math, double english, double science, double averageGrade)
        {
            Console.WriteLine("Math grade: " + math);
            Console.WriteLine("English grade: " + english);
            Console.WriteLine("Science grade: " + science);
            Console.Write("Average grade: " + averageGrade);
        }

        public double Math
        {
            set
            {
                if (value > 1 && value < 7)
                    this.math = value;
            }
            get
            {
                return this.math;
            }
        }
        public double English
        {
            set
            {
                if (value > 1 && value < 7)
                    this.english = value;
            }
            get
            {
                return this.english;
            }
        }
        public double Science
        {
            set
            {
                if (value >1 && value <7)
                this.science = value;
            }
            get
            {
                return this.science;
            }
        }
    }
}
