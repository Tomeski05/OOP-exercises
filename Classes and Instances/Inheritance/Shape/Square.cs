using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Shape
{
    public class Square: Rectangle
    {

        public Square()
        {

        }

        public Square(double side)
        {
            //(side, side);
        }

        public Square(double side, String color, bool filled)
        {
            //this.(side, side, color, filled);
        }

        public double getSide()
        {
            return this.getLength();
        }

        public void setWidth(double side)
        {
            this.setWidth(side);
            this.setLength(side);
        }

        public void setLength(double side)
        {
            this.setWidth(side);
            this.setLength(side);
        }

        public override string toString()
        {
            return $"Square + {this.toString()})";
        }
    }
}
