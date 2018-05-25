using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Sphere:ThreeDimensionalShape
    {
        private double radius;
        private const double pi = 3.14;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double calculateArea()
        {
            return 4 * radius * pi;
        }

        public override double calculateVolume()
        {
            return (4 / 3) * pi * radius * radius * radius;
        }

        public bool isSphere()
        {
            if (radius <= 0)
                return false;
            else
                return true;
        }
    }
}
