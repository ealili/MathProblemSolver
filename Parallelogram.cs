using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Parallelogram:TwoDimensionalShape
    {
        Parallelogram(double Base, double side, double height)
        {
            this.Base = Base;
            this.side = side;
            this.height = height;
        }

        public override double calculateArea()
        {
            return (Base * height);
        }

        public override double calculatePerimeter()
        {
            return 2*(Base+side);
        }

    }
}
