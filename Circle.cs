using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Circle : TwoDimensionalShape
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double calculateArea()
        {
            return radius * radius * pi;
        }

        public override double calculatePerimeter()
        {
            return 2 * radius * pi; 
        }

        public bool isCircle(double radius) //not allows user to enter negative values
        {
            if (radius < 0)
                return false;
            else
                return true;
        }
    }
}
