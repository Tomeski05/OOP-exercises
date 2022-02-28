using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Shape
{
    class TestMain
    {
        public static void main(String[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine(c1);
            Circle c2 = new Circle(1);
            Console.WriteLine(c2);
            Circle c3 = new Circle(2, "black", true);
            Console.WriteLine(c3);

            c1.setColor("yellow");
            c1.setFilled(false);
            c1.setRadius(3);
            Console.WriteLine(c1);
            Console.WriteLine("Area: " + c1.getArea());
            Console.WriteLine("Perimeter: " + c1.getPerimeter());

            Rectangle r1 = new Rectangle();
            Console.WriteLine(r1);
            Rectangle r2 = new Rectangle(1, 2);
            Console.WriteLine(r2);
            Rectangle r3 = new Rectangle(3, 4, "black", true);
            Console.WriteLine(r3);

            r1.setColor("yellow");
            r1.setFilled(false);
            r1.setLength(5);
            r1.setWidth(6);
            Console.WriteLine(r1);
            Console.WriteLine("Area: " + r1.getArea());
            Console.WriteLine("Perimeter: " + r1.getPerimeter());

            Square s1 = new Square();
            Console.WriteLine(s1);
            Square s2 = new Square(1);
            Console.WriteLine(s2);
            Square s3 = new Square(3, "black", true);
            Console.WriteLine(s3);

            s1.setColor("yellow");
            s1.setFilled(false);
            s1.setLength(5);
            Console.WriteLine(s1);
            Console.WriteLine("Area: " + s1.getArea());
            Console.WriteLine("Perimeter: " + s1.getPerimeter());
        }
    }
}
