using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.GeometricObject
{
    class TestMain
    {
        public static void main(String[] args)
        {
            IGeometricObject c1;
            c1 = new Circle(1);
            Console.WriteLine(c1);

            IGeometricObject c2;
            c2 = new Circle(2);
            Console.WriteLine(c2);
            Console.WriteLine("Area: " + c2.getArea());
            Console.WriteLine("Perimeter: " + c2.getPerimeter());

            IGeometricObject r1;
            r1 = new Rectangle(1, 2);
            Console.WriteLine(r1);

            IGeometricObject r2;
            r2 = new Rectangle(3, 4);
            Console.WriteLine(r2);
            Console.WriteLine("Perimeter: " + r2.getPerimeter());
        }
    }
}
