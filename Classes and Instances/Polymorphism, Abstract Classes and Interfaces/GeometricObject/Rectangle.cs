using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.GeometricObject
{
    public class Rectangle: IGeometricObject
    {
        private double width;
        private double length;

        public Rectangle()
        {

        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public double getWidth()
        {
            return width;
        }

        public void setWidth(double width)
        {
            this.width = width;
        }

        public double getLength()
        {
            return length;
        }

        public void setLength(double length)
        {
            this.length = length;
        }

        public string toString()
        {
            return $"(Rectangle width = {width}, length = { length})";
        }

        public double getArea()
        {
            return length * width;
        }

        public double getPerimeter()
        {
            return (width + length) * 2;
        }


    }
}
