
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Point3D
{
    class TestPoint3D
    {
        public static void main(string[] args)
        {
            Point3D p1 = new Point3D(1, 2, 3);
            Console.WriteLine(p1);

            p1.setX(4);
            p1.setY(5);
            p1.setZ(6);
            Console.WriteLine(p1);
            Console.WriteLine("point X : " + p1.getX());
            Console.WriteLine("point Y : " + p1.getY());
            Console.WriteLine("point Z : " + p1.getZ());

            p1.setXY(7, 8);
            Console.WriteLine(p1);
            p1.setXYZ(9, 10, 11);
            //Console.WriteLine("new point: " + toString(p1.getXYZ()));

        }

    }
}
