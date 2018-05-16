using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    abstract class TwoDimensionalShape
    {
        public abstract double calculatePerimeter();
        public abstract double calculateArea();

        protected double Base;
        protected double height;
        protected double side1;
        protected double side2;
        protected double side3;
        protected double radius;
        public const double pi = 3.1415265352429;
    }

    class ValidationFunctions
    {
        //Function to validate the input type
        static public bool validateDoubleInput(string a)
        {
            double outValue;
            return double.TryParse(a, out outValue);
        }
    }
}
