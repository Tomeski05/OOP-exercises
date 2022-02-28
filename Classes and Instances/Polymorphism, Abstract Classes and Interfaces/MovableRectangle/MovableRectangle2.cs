using Polymorphism__Abstract_Classes_and_Interfaces.MovableRectangle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces
{
    public class MovableRectangle2: IMovable
    {

        private MovablePoint2 topLeft;
        private MovablePoint2 bottomRight;

        public MovableRectangle2()
        {

        }

        public MovableRectangle2(MovablePoint2 topLeft, MovablePoint2 bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        public MovablePoint2 getTopLeft()
        {
            return topLeft;
        }

        public void setTopLeft(MovablePoint2 topLeft)
        {
            this.topLeft = topLeft;
        }

        public MovablePoint2 getBottomRight()
        {
            return bottomRight;
        }

        public void setBottomRight(MovablePoint2 bottomRight)
        {
            this.bottomRight = bottomRight;
        }

        public string toString()
        {
            return $"(MovableRectangle + topLeft = { topLeft}, bottomRight = {bottomRight})";
        }

        public void moveUp()
        {
            this.topLeft.setY(this.topLeft.getY() - this.topLeft.getySpeed());
            this.bottomRight.setY(this.bottomRight.getY() - this.bottomRight.getySpeed());
        }

        public void moveDown()
        {
            this.topLeft.setY(this.topLeft.getY() + this.topLeft.getySpeed());
            this.bottomRight.setY(this.bottomRight.getY() + this.bottomRight.getySpeed());
        }

        public void moveLeft()
        {
            this.topLeft.setX(this.topLeft.getX() - this.topLeft.getxSpeed());
            this.bottomRight.setX(this.bottomRight.getX() - this.bottomRight.getxSpeed());
        }

        public void moveRight()
        {
            this.topLeft.setX(this.topLeft.getX() + this.topLeft.getxSpeed());
            this.bottomRight.setX(this.bottomRight.getX() + this.bottomRight.getxSpeed());
        }

    }
}
