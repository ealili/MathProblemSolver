using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class PyramidRectangularBased:ThreeDimensionalShape
    {
        private double Base;
        private double width;
        private double height;

        public PyramidRectangularBased(double Base, double height, double width)
        {
            this.Base = Base;
            this.width = width;
            this.height = height;
        }

        public override double calculateArea()
        {
            return (Base * width) + (Base * Math.Sqrt(Math.Pow((width / 2), 2) + Math.Pow(height, 2))) + (width * Math.Sqrt(Math.Pow((Base / 2), 2) + Math.Pow(height, 2))); // A=lw+l*sqrt((w/2)^2+h^2) +w*sqrt((l/2)^2+h^2)
        }

        public override double calculateVolume()
        {
            return ( Base * width * height )/ 3;
        }
    }
}
