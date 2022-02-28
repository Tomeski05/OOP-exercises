using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Shape
{
    public class Circle: Shape
    {
        private double radius = 1.0;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, string color, bool filled)
        {
            //(color, filled);
            this.color = color;
            this.filled = filled;
            this.radius = radius;
        }

        public double getArea()
        {
            return this.radius * this.radius * Math.PI;
        }

        public double getPerimeter()
        {
            return this.radius * 2 * Math.PI;
        }

        public override string toString()
        {
            return $"(Circle + {this.toString()} + ,radius = { radius})";
        }

        public void setRadius(int radius)
        {
            this.radius = radius;//To change body of generated methods, choose Tools | Templates.
        }
    }
}
