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
        protected double side;
        protected double side1;
        protected double side2;
        protected double radius;
        public const double pi = 3.1415265352429;

        internal static string setPrecision(double value)
        {
            string ret = value.ToString();
            //how many digits do you want to print you'll need to change the variable digits below
            int digits = 5;

            if (ret.Length > digits + 1)
                ret = Math.Round(value, digits + (value < 1 ? 1 : 0) - ret.IndexOf('.')).ToString();

            return ret;
        }

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
