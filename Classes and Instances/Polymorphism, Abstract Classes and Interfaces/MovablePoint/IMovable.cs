using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.MovablePoint
{
    interface IMovable
    {
        public abstract void moveUp();
        public abstract void moveDown();
        public abstract void moveLeft();
        public abstract void moveRight();
    }
}
