using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Triangle : TwoDimensionalShape
    {
       // protected double Base;
       // protected double side1;
       // protected double side2;


        public Triangle(double Base, double side, double side1)
        {
            this.Base = Base;
            this.side = side;
            this.side1 = side1;
        }

        public override double calculateArea()
        {
            double s, area;
            s = (Base + side + side1) / 2;
            area = (s * (s - Base) * (s - side) * (s - side1));
            return area;
        }

        public override double calculatePerimeter()
        {
            return Base + side + side1;
        }

    }
}
