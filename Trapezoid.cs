using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Trapezoid:TwoDimensionalShape
    {
        Trapezoid(double Base, double side1, double side2, double side3)
        {
            this.Base = Base;
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double calculateArea()
        {
            return (height * (Base + side1)) / 2;
        }

        public override double calculatePerimeter()
        {
            return Base + side1 + side2 + side3;
        }
    }
}
