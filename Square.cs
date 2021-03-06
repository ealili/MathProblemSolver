﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Square:TwoDimensionalShape
    {
        private double Base;
        public Square(double Base)
        {
            this.Base = Base;
        }

        public override double calculateArea()
        {
            return Math.Pow(Base, 2);
        }

        public override double calculatePerimeter()
        {
            return 4 * Base;
        }

        public bool isSquare()
        {
            if (Base <= 0)
                return false;
            else
                return true;
        }
    }
}
