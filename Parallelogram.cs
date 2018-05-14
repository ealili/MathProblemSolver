using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Parallelogram:TwoDimensionalShape
    {
        Parallelogram(double Base, double side1)
        {
            this.Base = Base;
            this.side1 = side1;
            
        }

        public override double calculateArea()
        {
            return (Base * height);
        }

        public override double calculatePerimeter()
        {
            return 2*(Base+side1);
        }

    }
}
