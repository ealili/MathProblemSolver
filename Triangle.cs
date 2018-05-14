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


        public Triangle(double Base, double side1, double side2)
        {
            this.Base = Base;
            this.side1 = Base;
            this.side2 = Base;
        }

        public override double calculateArea()
        {
            double s, area;
            s = (Base + side1 + side2) / 2;
            area = (s * (s - Base) * (s - side1) * (s - side2));
            return area;
        }

        public override double calculatePerimeter()
        {
            return Base + side1 + side2;
        }

    }
}
