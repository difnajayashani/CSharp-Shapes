using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes 
{
    public class Circle : Shapes
    {
        private double radius;
        private static double constatnt = Math.PI;

        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            return ( constatnt *(Math.Pow( radius,2)));
        }

        public override double getCircumference()
        {
            return (2 * constatnt * radius);
        }

        public static Circle operator +(Circle c1, Circle c2)
        {
            Circle compoundCircle = new Circle();
            compoundCircle.radius = c1.radius + c2.radius;
            return compoundCircle;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return this.radius;
        }
    }
}
