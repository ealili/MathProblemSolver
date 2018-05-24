using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Trapezoid:TwoDimensionalShape
    {
        private double Base;
        private double side;
        private double side1;
        private double side2;
        private double height;

        public Trapezoid(double Base, double side, double side1, double side2, double height)
        {
            this.Base = Base;
            this.side1 = side1;
            this.side2 = side2;
            this.side = side;
            this.height = height;
        }

        public override double calculateArea()
        {
            return (height * (Base + side)) / 2;
        }

        public override double calculatePerimeter()
        {
            return Base + side1 + side2 + side;
        }
    }
}
