using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Point3D
{
    public class Point3D: Point2D
    {
        private float z;

        public Point3D()
        {

        }

        public Point3D(float x, float y, float z)
        {
            //this.x = x;
            //this.y = y;
            this.z = z;
        }

        public float getZ()
        {
            return z;
        }

        public void setZ(float z)
        {
            this.z = z;
        }

        public void setXYZ(float x, float y, float z)
        {
            setXY(x, y);
            this.z = z;
        }

        public float[] getXYZ()
        {
            float[] list = new float[] { getX(), getY(), z };
            return list;
        }

        public override string toString()
        {
            return $"( {getX()} + {getY()} + {z})";
        }
    }
}
