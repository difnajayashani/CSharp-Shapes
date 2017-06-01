using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Pentagon : Shapes
    {
        private double side;

        public Pentagon() { }

        public Pentagon(double side)
        {
            this.side = side;
        }
        public override double getArea()
        {
            double q = 5 * (2 * Math.Sqrt(5) + 5);
            double output= 0.25 * Math.Sqrt(q) * Math.Pow(side, 2);
            return output;
        }

        public override double getCircumference()
        {
            return 5 * side;
        }

        public static Pentagon operator +(Pentagon c1, Pentagon c2)
        {
            Pentagon compoundPentagon = new Pentagon();
            compoundPentagon.side = c1.side + c2.side;
            return compoundPentagon;
        }
    }
}
