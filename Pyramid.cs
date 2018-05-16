using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemSolver
{
    class Pyramid:ThreeDimensionalShape
    {
        public Pyramid(double Base, double height, double width)
        {
            this.Base = Base;
            this.width = width;
            this.height = height;
        }

        public override double calculateArea()
        {
            return (Base * width) + (Base * Math.Sqrt(Math.Pow((width / 2), 2) + Math.Pow(height, 2))) + (width * Math.Sqrt(Math.Pow((Base / 2), 2) + Math.Pow(height, 2)));
        }

        public override double calculateVolume()
        {
            return ( Base * width * height )/ 3;
        }
    }
}
