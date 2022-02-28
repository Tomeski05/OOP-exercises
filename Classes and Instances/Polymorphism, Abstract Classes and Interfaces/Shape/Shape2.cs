using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces
{
    public abstract class Shape2
    {

        protected string color = "red";
        protected bool filled = true;

        public Shape2()
        {
        }

        public Shape2(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public bool isFilled()
        {
            return filled;
        }

        public void setFilled(bool filled)
        {
            this.filled = filled;
        }

        public abstract double getArea();

        public abstract double getPerimeter();

        public virtual string toString()
        {
            return $"(Shape color = { color} ,filled = { filled})";
        }
    }
}
