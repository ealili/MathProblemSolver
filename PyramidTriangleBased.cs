using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class PyramidTriangleBased:ThreeDimensionalShape
    {
        private double Base;
        private double BaseHeight;// the height of the base 
        // the variable "height" is the height of the pyramid
        private double width;
        private double height;

        public PyramidTriangleBased(double Base, double width, double height, double BaseHeight)
        {
            this.Base = Base;
            this.width = width;
            this.height = height; // height of the pyramid
            this.BaseHeight = BaseHeight; // height of the base
        }

        public override double calculateArea()
        {
            double baseArea = 0;
            baseArea = (Math.Sqrt(3) / 4) * Math.Pow(Base, 2);
            return ((1 / 2 * Base * height)*3)+baseArea;
        }

        public override double calculateVolume()
        {
            return ((1 / 2 * Base * BaseHeight) / 3) * height; // http://virtualnerd.com/pre-algebra/perimeter-area-volume/volume/volume-examples/triangular-pyramid-volume-example
        }
    }
}
