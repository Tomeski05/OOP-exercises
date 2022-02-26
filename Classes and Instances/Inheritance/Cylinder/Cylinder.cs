using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Cylinder: Circle
    {
        private double height = 1.0;

        public Cylinder()
        {

        }

        public Cylinder(double radius)
        {
            this.radius = radius;
        }

        public Cylinder(double radius, double height)
        {
            this.height = height;
            this.radius = radius;
        }

        public Cylinder(double radius, double height, string color)
        {
            this.height = height;
            this.radius = radius;
            this.color = color;
        }

        public double getHeight()
        {
            return height;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public double getVolume()
        {
            return getArea() * height;
        }

        public override string toString()
        {
            return $"{color}";
        }

    }
}
