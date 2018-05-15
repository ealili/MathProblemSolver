using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Sphere:ThreeDimensionalShape
    {
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
    }
}
