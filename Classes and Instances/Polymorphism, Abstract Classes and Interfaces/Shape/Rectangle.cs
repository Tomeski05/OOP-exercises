using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.Shape
{
    public class Rectangle: Shape2
    {
        protected double width;
        protected double length;

        public Rectangle()
        {
        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, string color, bool filled)
        {
            //super(color, filled);
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

        public override double getArea()
        {
            return this.length * this.width;
        }

        public override double getPerimeter()
        {
            return (this.length + this.width) * 2;
        }

        public override string toString()
        {
            return $"(Rectangle  {this.toString()} ,width =  { width}, length = { length})";
        }


    }
}
