using Polymorphism__Abstract_Classes_and_Interfaces.MovableCircle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces
{
    public class MovablePoint2: IMovable
    {
        private int x;
        private int y;
        private int xSpeed;
        private int ySpeed;

        public MovablePoint2()
        {
        }

        public MovablePoint2(int x, int y, int xSpeed, int ySpeed)
        {
            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public int getX()
        {
            return x;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public int getY()
        {
            return y;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public int getxSpeed()
        {
            return xSpeed;
        }

        public void setxSpeed(int xSpeed)
        {
            this.xSpeed = xSpeed;
        }

        public int getySpeed()
        {
            return ySpeed;
        }

        public void setySpeed(int ySpeed)
        {
            this.ySpeed = ySpeed;
        }

        public String toString()
        {
            return $"( + x + , + y + ) speed = {xSpeed},  { ySpeed})";
        }

        public void moveUp()
        {
            this.y -= this.ySpeed;
        }

        public void moveDown()
        {
            this.y += this.ySpeed;
        }

        public void moveLeft()
        {
            this.x -= this.xSpeed;
        }

        public void moveRight()
        {
            this.x += this.xSpeed;
        }
    }
}
