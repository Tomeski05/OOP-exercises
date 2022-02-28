using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.Resizable
{
    class TestMain
    {
        public static void main(String[] args)
        {
            IGeometricObject g1 = new Circle(1.2);
            Console.WriteLine(g1);
            Console.WriteLine("Perimeter = " + g1.getPerimeter());
            Console.WriteLine("Area = " + g1.getArea());

            IResizable g2 = new ResizableCircle(3.4);
            Console.WriteLine(g2);
            Console.WriteLine(g2);

            IGeometricObject g3 = (IGeometricObject)g2;
            Console.WriteLine(g3);
            Console.WriteLine("Perimeter = " + g3.getPerimeter());
            Console.WriteLine("Area = " + g3.getArea());
        }
    }
}
