using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Cylinder:ThreeDimensionalShape
    {
        private double radius;
        private double height;
        private const double pi = 3.14;

        public Cylinder(double radius,double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double calculateArea()
        {
            return (2 * radius * pi * height) + (2 * Math.Pow(radius, 2) * pi);
        }

        public override double calculateVolume()
        {
            return Math.Pow(radius, 2) * pi * height;
        }

        public bool isCylinder()
        {
            if (radius <= 0 && height <= 0)
                return false;
            else
                return true;
        }
    }
}
