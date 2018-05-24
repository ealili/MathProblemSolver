using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Parallelogram:TwoDimensionalShape
    {
        private double Base;
        private double side;
        private double height;
        public Parallelogram(double Base, double side, double height)
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

        public bool isParallelogram(double Base, double side, double height)
        {
            //if base and side are equal, there is formed romb, but we do not have that form and do not do function to exclude that situation
            if (Base < 0 && side < 0 && height < 0)
                return false;
            else
                return true;
        }

    }
}
