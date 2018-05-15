using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Cube:ThreeDimensionalShape
    {
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
    }
}
