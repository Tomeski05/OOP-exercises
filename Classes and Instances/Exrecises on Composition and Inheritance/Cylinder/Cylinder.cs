using System;
using System.Collections.Generic;
using System.Text;

namespace Exrecises_on_Composition_and_Inheritance
{
    public class Cylinder : Circle
    {

        private Circle base;
        private double height = 1.0;

        public Cylinder()
        {
            this.base = new Circle();
        }

        public Cylinder(double radius)
        {
            //this.radius = radius;;
            this.base = new Circle();
        }

        public Cylinder(double radius, string color)
        {
            this.(radius, color);
            this.base = new Circle();
        }

        public Cylinder(double radius, double height)
        {
            //this.radius = radius;
            this.base = new Circle();
            this.height = height;
        }

        public Cylinder(double radius, double height, string color)
        {
            this.(radius, color);
            this.height = height;
            this.base = new Circle();
        }


        public Cylinder(double radius1, string color1, double radius2, string color2)
        {
            //this.radius1 = radius1;
            //this.color1 = color1;
            this.base = new Circle(radius2, color2);
        }

        public Cylinder(double height, double radius1, string color1, double radius2, string color2)
        {
            //this.radius1 = radius1;
            //this.color1 = color1;
            this.height = height;
            this.base = new Circle(radius2, color2);
        }

        public Cylinder(double radius1, string color1, double radius2, string color2, double height)
        {
            //this.radius1 = radius1;
            //this.color1 = color1;
            this.height = height;
            this.base = new Circle(radius2, color2);
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
            return this.getArea() * this.height;
        }

        public Circle getBase()
        {
            return base;
        }

        public void setBase(Circle base)
        {
            this.base = base;
        }

        public string toString()
        {
            return $"(Cylinder circle = {this.toString()} base = { base}, height =  { height})";
        }
    }
}
