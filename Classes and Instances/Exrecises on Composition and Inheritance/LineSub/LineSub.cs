using System;
using System.Collections.Generic;
using System.Text;

namespace Exrecises_on_Composition_and_Inheritance
{
    public class LineSub: Point
    {
        private Point end;

        public LineSub(Point begin, Point end)
        {
            //this.(begin.getX(), begin.getY());
            this.end = end;
        }

        public LineSub(int beginX, int beginY, int endX, int endY)
        {
            //this.beginX = beginX;
            //this.beginY = beginY;
            end = new Point(endX, endY);
        }

        public string toString()
        {
            return $"(LineSub begin = { toString()},end =  { end})";
        }

        public Point getBegin()
        {
            return new Point(getX(), getY());
        }

        public Point getEnd()
        {
            return end;
        }

        public void setBegin(int beginX, int beginY)
        {
            setXY(beginX, beginY);
        }

        public void setEnd(int endX, int endY)
        {
            end.setXY(endX, endY);
        }

        public int getBeginX()
        {
            return getX();
        }

        public int getBeginY()
        {
            return getY();
        }

        public int getEndX()
        {
            return end.getX();
        }

        public int getEndY()
        {
            return end.getY();
        }

        public void setBeginX(int beginX)
        {
            setX(beginX);
        }

        public void setBeginY(int beginY)
        {
            setY(beginY);
        }

        public void setBeginXY(int beginX, int beginY)
        {
            setXY(beginX, beginY);
        }

        public void setEndX(int endX)
        {
            end.setX(endX);
        }

        public void setEndY(int endY)
        {
            end.setY(endY);
        }

        public void setEndXY(int endX, int endY)
        {
            end.setXY(endX, endY);
        }

        public int getLength()
        {
            return (int)(Math.Sqrt(Math.Pow(end.getX() - getX(), 2) + Math.Pow(end.getY() - getY(), 2)));
        }
        public double getGradient()
        {
            //return (double)((end.getY() - getY(), end.getX() - getX()));
        }

    }
}
