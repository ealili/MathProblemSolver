using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Cone:ThreeDimensionalShape
    {
        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double calculateArea()
        {
            return pi * radius * (radius + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius, 2)));
        }

        public override double calculateVolume()
        {
            return Math.Pow(radius, 2) * pi * (height / 3);
        }
    }
}
