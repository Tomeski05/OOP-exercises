using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.Resizable
{
    public class ResizableCircle: Circle, IResizable
    {
        public double radius;

        public ResizableCircle(double radius)
        {
            this.radius = radius;
        }

        public ResizableCircle()
        {
        }

        public String toString()
        {
            return $"(ResizableCircle " + " {this.toString()})";
        }

        public void resize(int percent)
        {
            radius *= percent / 100;
        }

    }
}
