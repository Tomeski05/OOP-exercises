using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.MovablePoint
{
    public class Point
    {
        private float x;
        private float y;

        public Point()
        {

        }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float getX()
        {
            return x;
        }

        public void setX(float x)
        {
            this.x = x;
        }

        public float getY()
        {
            return y;
        }

        public void setY(float y)
        {
            this.y = y;
        }

        public float[] getXY()
        {
            return new float[] { this.x, this.y };
        }

        public void setXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual string toString()
        {
            return $"(x,y) = ({x},{y})";
        }
    }
}
