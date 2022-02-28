using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.Shape
{
    public class Square : Rectangle
    {
        protected double side;

        public Square()
        {

        }

        public Square(double side)
        {
            this.side = side;
            
        }

        public Square(double side, string color, bool filled)
        {
            //super(side, side, color, filled);
            this.color = color;
        }

        public double getSide()
        {
            return this.getLength();
        }

        public void setWidth(double side)
        {
            //super.setWidth(side);
            //super.setLength(side);
        }

        public void setLength(double side)
        {
            //super.setWidth(side);
            //super.setLength(side);
        }

        public override string toString()
        {
            return $"(Square {this.toString()})";
        }
    }
}
