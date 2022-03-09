using System;
using System.Collections.Generic;
using System.Text;

namespace Exrecises_on_Composition_and_Inheritance
{
    public class Circle
    {
        private string color = "red";
        public string Color
        {
            get => color;
            set => color = value;
        }

        private double radius = 1.0;
        public double Radius
        {
            get => radius;
            set => radius = value;
        }

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

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public virtual string toString()
        {
            return $"(Circle radius = { radius}, color =  { color})";
        }
    }

}