using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//can you find the mistake my friend

namespace MathProblemSolver
{
    class Rectangle: TwoDimensionalShape
    {
        public Rectangle(double Base, double side1)
        {
            this.Base = Base;
            this.side1 = side1;
        }

        public override double calculateArea()
        {
            return Base * side1;
        }

        public override double calculatePerimeter()
        {
            return 2 * (Base + side1);
        }
        
    }
}
