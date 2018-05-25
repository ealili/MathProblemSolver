using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Cube:ThreeDimensionalShape
    {
        private double Base;

        public Cube(double Base)
        {
            this.Base = Base;
        }

        public override double calculateVolume()
        {
            return Base * Base * Base;
        }

        public override double calculateArea()
        {
            return 6 * Base * Base;
        }

        public bool isCube()
        {
            if (Base <= 0)
                return false;
            else
                return true;
        }
    }
}
