using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Shape
{
    public class Shape
    {
        public string color = "red";
        public bool filled = true;

        public Shape()
        {
        }

        public Shape(string color, bool filled)
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

        public virtual string toString()
        {
            return $"(Shape + color = + { color} + ,filled = { filled})";
        }
    }
}
