using System;

namespace Inheritance
{
    public class Circle 
    {
        public double radius = 1.0;
        public string color = "red";

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public virtual string toString()
        {
            return $"Circle radius = {radius} and color {color} ";
        }

    }
}
