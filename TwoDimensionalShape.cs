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
        //public abstract void validateInput();
        protected double Base;
        protected double side1;
        protected double side2;
        protected double radius;
    }

    class ValidationFunctions
    {
        static public bool validateDoubleInput(string a)
        {
            double outValue;
            return double.TryParse(a, out outValue);
        }
    }
}
