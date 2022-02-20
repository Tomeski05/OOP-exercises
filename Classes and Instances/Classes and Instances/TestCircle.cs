using System;

namespace Classes_and_Instances
{
    class TestCircle
    {
        static void Main(string[] args)
        {
            // Declare an instance of Circle class called c1.
            // Construct the instance c1 by invoking the "default" constructor
            // which sets its radius and color to their default value.
            Circle c1 = new Circle();
            // Invoke public methods on instance c1, via dot operator.
            Console.WriteLine("The circle has radius of "
               + c1.getRadius() + " and area of " + c1.getArea());
            //The circle has radius of 1.0 and area of 3.141592653589793

            // Declare an instance of class circle called c2.
            // Construct the instance c2 by invoking the second constructor
            // with the given radius and default color.
            Circle c2 = new Circle(2.0);
            // Invoke public methods on instance c2, via dot operator.
            Console.WriteLine("The circle has radius of "
               + c2.getRadius() + " and area of " + c2.getArea());
            //The circle has radius of 2.0 and area of 12.566370614359172


            Circle c3 = new Circle(2.5, "green");
            Console.WriteLine("The circle has radius" 
                + c3.getRadius() + " and area of " + c3.getArea() + " with color " + c3.getColor());


            // Setiranje na nova vrednost i instanciranje na konsruktor so hardkodirani vrednsti
            Circle c4 = new Circle();
            c4.setRadius(1.5);
            Console.WriteLine("New radius is" + c4.getRadius());
            c4.setColor("blue");
            Console.WriteLine("New color is" + c4.getColor());



            Console.ReadLine();
        }
        
        public class Circle
        {
            private double radius;
            private string color;

            public Circle()
            {
                radius = 1.0;
                color = "red";
            }

            public Circle(double r)
            {
                radius = r;
                color = "red";
            }

            public Circle(double r, string c)
            {
                radius = r;
                color = c;
            }

            public string getColor()
            {
                return color;
            }

            public double getRadius()
            {
                return radius;
            }

            public double getArea()
            {
                return radius * radius * Math.PI;
            }

            public void setRadius(double newRadius)
            {
                radius = newRadius;
            }

            public void setColor(string newColor)
            {
                color = newColor;
            }
        }
    }
}
