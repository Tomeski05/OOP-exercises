using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.MovablePoint
{
    public class TestMovablePoint
    {
        public static void main(String[] args)
        {
            MovablePoint m1 = new MovablePoint();
            Console.WriteLine(m1);
            MovablePoint m2 = new MovablePoint(1, 2);
            Console.WriteLine(m2);
            MovablePoint m3 = new MovablePoint(3, 4, 5, 6);
            Console.WriteLine(m3);

            m1.setX(7);
            m1.setY(8);
            m1.setxSpeed(9);
            m1.setySpeed(10);
            Console.WriteLine(m1);
            Console.WriteLine("Move: " + m1.move());
        }
    }
}
