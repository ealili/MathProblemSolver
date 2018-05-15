using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    abstract class ThreeDimensionalShape
    {
        public abstract double calculateVolume();
        public abstract double calculateArea();
        //public abstract void validateInput();

        protected double Base;
        protected double height;
        protected double width;
        protected double side1;
        protected double side2;
        protected double side3;
        protected double radius;
        public const double pi = 3.1415265352429;
    }

}
