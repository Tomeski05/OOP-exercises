using System;
using System.Collections.Generic;
using System.Text;

namespace Exrecises_on_Composition_and_Inheritance
{
    public class Cylinder : Circle
    {

       
        private double height = 1.0;

        public Cylinder()
        {
            
        }

        public Cylinder(double radius)
        {
            Radius = radius;
        }

        public Cylinder(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            this.height = height;
        }

        public Cylinder(double radius, double height, string color)
        {
            Radius = radius;
            Color = color;
            this.height = height;
        }


        public Cylinder(double radius1, string color1, double radius2, string color2)
        {
            Radius = radius1;
            Color = color1;
            Radius = radius2;
            Color = color2;
        }

        public Cylinder(double height, double radius1, string color1, double radius2, string color2)
        {
            Radius = radius1;
            Color = color1;
            this.height = height;
            Radius = radius2;
            Color = color2;
        }

        public Cylinder(double radius1, string color1, double radius2, string color2, double height)
        {
            Radius = radius1;
            Color = color1;
            this.height = height;
            Radius = radius2;
            Color = color2;
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
            return $"(Cylinder circle = {toString()}, height =  { height})";
        }
    }
}
