using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class TestCylinder
    {
        public static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Console.WriteLine("Cylinder:"
                  + " radius=" + c1.getRadius()
                  + " height=" + c1.getHeight()
                  + " base area=" + c1.getArea()
                  + " volume=" + c1.getVolume());


            Cylinder c2 = new Cylinder(10.0);
            Console.WriteLine("Cylinder:"
                  + " radius=" + c2.getRadius()
                  + " height=" + c2.getHeight()
                  + " base area=" + c2.getArea()
                  + " volume=" + c2.getVolume());


            Console.ReadLine();

        }
    }
}
