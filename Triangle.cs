using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Triangle : TwoDimensionalShape
    {
       private double Base;
       private double side;
       private double side1;


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

        public bool isTriangle()
        {
            if (Base <= 0 && side <= 0 && side1 <= 0) // if the dimensions can't form a triangle return false
                return false;
            else if (Base + side > side1 && side1 + side > Base && Base + side1 > side) // if the dimensions form a triangle return true
                return true;
            else
                return false; // any dimensions that can't comply to form a triangle returns false
        }

    }
}
