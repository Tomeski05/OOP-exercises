using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.Shape
{
    public class Circle: Shape2
    {
        protected double radius = 1.0;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
            this.radius = radius;
        }

        public override double getArea()
        {
            return this.radius * this.radius * Math.PI;
        }

        public override double getPerimeter()
        {
            return this.radius * 2 * Math.PI;
        }

        public string toString()
        {
            return $"(Circle { this.toString()}, radius = { radius}";
        }

        public void setRadius(int radius)
        {
            this.radius = radius;
        }
    }
}
