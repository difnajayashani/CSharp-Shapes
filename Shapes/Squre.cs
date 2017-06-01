using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Squre : Shapes
    {
        private double length;

        public Squre()
        {
        }
        public Squre(double length)
        {
            this.length = length;
        }

        public override double getArea()
        {
            return (Math.Pow(length, 2));
        }

        public override double getCircumference()
        {
            return (4 * length);
        }

        public static Squre operator+(Squre s1,Squre s2)
        {
            Squre compounSqure = new Squre();
            compounSqure.length = s1.length + s2.length;
            return compounSqure;

        }

        public void setLength(double length)
        {
            this.length = length;
        }
        public double getLength()
        {
            return this.length;
        }

      
    }
}
