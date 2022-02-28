using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.Resizable
{
    public class Circle: IGeometricObject
    {

        protected double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle()
        {
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public string toString()
        {
            return $"(Circle radius =  { radius})";
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getPerimeter()
        {
            return radius * 2 * Math.PI;
        }

    }
}
