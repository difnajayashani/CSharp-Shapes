using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shapes
    {
        private double length;
        private double width;

        public Rectangle() { }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double getArea()
        {
            return (length * width);
        }

        public override double getCircumference()
        {
            return 2*(length * width);
        }

        public static Rectangle operator +(Rectangle s1, Rectangle s2)
        {
            Rectangle compoundRectangle = new Rectangle();
            compoundRectangle.length = s1.length + s2.length;
            compoundRectangle.width = s1.width + s2.width;

            return compoundRectangle;

        }
    }
}
