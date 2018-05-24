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
        public Rectangle(double Base, double height)
        {
            this.Base = Base;
            this.height = height;
        }

        public override double calculateArea()
        {
            return Base * height;
        }

        public override double calculatePerimeter()
        {
            return 2 * (Base + height);
        }

        public bool isRectangle (double Base, double height) // function that controls if given values forms rectangle
        {
            if (Base < 0 && height < 0)
                return false;
            else if (Base == height)
                return false;
            else
                return true;
        }
        
    }
}
