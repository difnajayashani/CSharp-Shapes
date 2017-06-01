using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Squre object
            Squre squre1 = new Squre(10.0);
            Squre squre2 = new Squre(12.5);
            Squre compoundSqure = new Squre();
           
            Console.WriteLine("Squre1 Circumference is:"+squre1.getCircumference());
            Console.WriteLine("Squre1 Area is:"+squre1.getArea());

            compoundSqure = squre1 + squre2;
            Console.WriteLine("Compound squre length:" + compoundSqure.getLength());
            Console.WriteLine("Compound squre area:" + compoundSqure.getArea());
            Console.WriteLine("Compound squre circumference:" + compoundSqure.getCircumference());
            Console.WriteLine("=============================================");

            //Circle Object
            Circle circle1 = new Circle(10.0);
            Circle circle2 = new Circle(12.5);
            Circle compoundCircle = new Circle();
            Console.WriteLine("Circle1 Circumference is:" + circle1.getCircumference());
            Console.WriteLine("Circle2 Area is:" + circle2.getArea());

            compoundCircle = circle1 + circle2;
            Console.WriteLine("Compound circle length:" + compoundCircle.getRadius());
            Console.WriteLine("Compound circle area:" + compoundCircle.getArea());
            Console.WriteLine("Compound circle circumference:" + compoundCircle.getCircumference());
            Console.WriteLine("=============================================");

            //triangle object
            Triangle triangle1 = new Triangle(5.0, 10.0);
            Triangle triangle2 = new Triangle(15.0, 50.0);
            Triangle compoundTriangle = new Triangle();
            Console.WriteLine("Triangle1 Circumference is:" + triangle1.getCircumference());
            Console.WriteLine("Triangle1 Area is:" + triangle1.getArea());

            compoundTriangle = triangle1 + triangle2;
            Console.WriteLine("Compound triangle length:" + compoundTriangle.getHeight());
            Console.WriteLine("Compound triangle area:" + compoundTriangle.getArea());
            Console.WriteLine("Compound triangle circumference:" + compoundTriangle.getCircumference());
            Console.WriteLine("=============================================");

            //rectangle object
            Triangle rectangle1 = new Triangle(5.0, 10.0);
            Triangle rectangle2 = new Triangle(15.0, 50.0);
            Triangle compoundRectangle = new Triangle();
            Console.WriteLine("Rectangle1 Circumference is:" + rectangle1.getCircumference());
            Console.WriteLine("Rectangle1 Area is:" + rectangle1.getArea());

            compoundRectangle = rectangle1 + rectangle2;
            Console.WriteLine("Compound rectangle length:" + compoundRectangle.getHeight());
            Console.WriteLine("Compound rectangle area:" + compoundRectangle.getArea());
            Console.WriteLine("Compound rectangle circumference:" + compoundRectangle.getCircumference());
            Console.WriteLine("=============================================");

            //Pentagon object
            Pentagon pentagon1 = new Pentagon(3.0);
            Pentagon pentagon2 = new Pentagon(15.0);
            Pentagon compoundPentagon = new Pentagon();
            Console.WriteLine("Pentagon1 Circumference is:" + pentagon1.getCircumference());
            Console.WriteLine("Pentagon1 Area is:" + pentagon1.getArea());

            compoundPentagon = pentagon1 + pentagon2;
            Console.WriteLine("Compound pentagon length:" + compoundRectangle.getHeight());
            Console.WriteLine("Compound pentagon area:" + compoundRectangle.getArea());
            Console.WriteLine("Compound pentagon circumference:" + compoundRectangle.getCircumference());
            Console.WriteLine("=============================================");

            Console.ReadLine();


            
        }
    }
}
