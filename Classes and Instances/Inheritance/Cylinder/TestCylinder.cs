using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class TestCylinder
    {
        public static void Main(string[] args)
        {
            // Declare and allocate a new instance of cylinder
            //   with default color, radius, and height

            Cylinder c1 = new Cylinder();
            Console.WriteLine("Cylinder:"
                  + " color = " + c1.toString()
                  + " radius = " + c1.getRadius()
                  + " height = " + c1.getHeight()
                  + " base area = " + c1.getArea()
                  + " volume = " + c1.getVolume());

            // Declare and allocate a new instance of cylinder
            //   specifying height, with default color and radius

            Cylinder c2 = new Cylinder(10.0);
            Console.WriteLine("Cylinder:"
                  + " radius = " + c2.getRadius()
                  + " height = " + c2.getHeight()
                  + " base area = " + c2.getArea()
                  + " volume = " + c2.getVolume());

            // Declare and allocate a new instance of cylinder
            //   specifying radius and height, with default color

            Cylinder c3 = new Cylinder(2.0, 10.0);
            Console.WriteLine("Cylinder:"
                  + " radius = " + c3.getRadius()
                  + " height = " + c3.getHeight()
                  + " base area = " + c3.getArea()
                  + " volume = " + c3.getVolume());

            Console.ReadLine();

        }
    }
}
