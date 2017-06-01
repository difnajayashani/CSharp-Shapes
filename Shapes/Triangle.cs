using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shapes
    {
        private double height;
        private double baseSide;

        public Triangle() { }

        public Triangle(double height, double baseSide)
        {
            this.height = height;
            this.baseSide = baseSide;
        }
        public override double getArea()
        {
            return (0.5 * baseSide * height);
        }

        public override double getCircumference()
        {
            return (3 * baseSide);
        }

        public static Triangle operator +(Triangle s1, Triangle s2)
        {
            Triangle compoundTriangle = new Triangle();
            compoundTriangle.baseSide = s1.baseSide + s2.baseSide;
            compoundTriangle.height = s1.height + s2.height;

            return compoundTriangle;

        }
        public double getHeight()
        {
            return height;
        }
        public double getLength()
        {
            return baseSide;
        }
    }
}
