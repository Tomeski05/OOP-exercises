using System;
using System.Collections.Generic;
using System.Text;

namespace Exrecises_on_Composition_and_Inheritance.LineSub
{
    class Line: Point
    {

        private Point begin;   
        private Point end;     

        // Constructors
        public Line(Point begin, Point end)
        {
            this.begin = begin;
            this.end = end;
        }
        public Line(int beginX, int beginY, int endX, int endY)
        {
            begin = new Point(beginX, beginY);   
        }

        public string toString()
        {

        }

        public Point getBegin() { }
        public Point getEnd() { }
        public void setBegin(......) { }
        public void setEnd(......) {  }

        public int getBeginX() { }
        public int getBeginY() {  }
        public int getEndX() {  }
        public int getEndY() {  }

        public void setBeginX(......) { }
        public void setBeginY(......) {  }
        public void setBeginXY(......) {  }
        public void setEndX(......) {  }
        public void setEndY(......) { }
        public void setEndXY(......) { }

        public int getLength() {  } 
        public double getGradient() {  }

    }
}
