using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Cuboid:ThreeDimensionalShape
    {
        private double Base;
        private double width;
        private double height;

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

        public bool isCuboid()
        {
            if (Base <= 0 && width <= 0 && height <= 0)
                return false;
            else if (Base == width && Base == height && width == height) //if this is true, then entered values forms cube not cuboid
                return false;
            else
                return true;
        }
    }
}
