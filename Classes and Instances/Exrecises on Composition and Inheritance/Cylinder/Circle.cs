using System;
using System.Collections.Generic;
using System.Text;

namespace Exrecises_on_Composition_and_Inheritance
{
    public class Circle
    {
        private double radius = 1.0;
        private string color = "red";

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
            return this.radius * this.radius * Math.PI;
        }

        public string toString()
        {
            return $"(Circle radius = { radius}, color =  { color})";
        }
    }

}