using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Cuboid:ThreeDimensionalShape
    {
        public Cuboid(double Base, double width, double height)
        {
            this.Base = Base;
            this.width = width;
            this.height = height;
        }

        public override double calculateArea()
        {
            return 2 * (Base * width) + 2 * (Base * height) + 2 * (width * height);
        }

        public override double calculateVolume()
        {
            return Base * width * height;
        }
    }
}
