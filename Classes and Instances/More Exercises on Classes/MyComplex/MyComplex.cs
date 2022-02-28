using System;
using System.Collections.Generic;
using System.Text;

namespace More_Exercises_on_Classes.MyComplex
{
    public class MyComplex
    {
        private double real;
        private double imag;

        public MyComplex()
        {

        }

        public MyComplex(double real, double imag)
        {
            this.real = real;
            this.imag = imag;
        }

        public double getReal()
        {
            return real;
        }

        public void setReal(double real)
        {
            this.real = real;
        }

        public double getImag()
        {
            return imag;
        }

        public void setImag(double imag)
        {
            this.imag = imag;
        }

        public string toString()  
        {
            return $"( + {real} + "+" + {imag} { i})";
        }

        public bool isReal()
        {
            return (real == 0);
        }

        public bool isImaginary()
        {
            return (imag == 0);
        }

        public bool equals(double real, double imag)
        {
            return (this.real == real && this.imag == imag);
        }

        public bool equals(MyComplex another)
        {
            return (this.real == another.real && this.imag == another.imag);
        }

        public double Magnitude()
        {
            return (double)(Math.Sqrt(real * real + imag * imag));
        }

        //public double argument()
        //{
        //    return;
        //}

        public MyComplex addInto(MyComplex right)
        {
            this.real += right.real;
            this.imag += right.imag;
            return this;
        }

        public MyComplex add(MyComplex right)
        {
            this.real += right.real;
            this.imag += right.imag;
            return this;
        }

        public MyComplex addNew(MyComplex right)
        {
            return new MyComplex(this.real + right.real, this.imag + right.imag);
        }

        public MyComplex subtract(MyComplex right)
        {
            this.real -= right.real;
            this.imag -= right.imag;
            return this;
        }

        public MyComplex subtractNew(MyComplex right)
        {
            return new MyComplex(this.real - right.real, this.imag - right.imag);
        }

        public MyComplex multiply(MyComplex right)
        {
            this.real = (this.real * right.real - this.imag * right.imag);
            this.imag = (this.real * right.imag + this.imag * right.real);
            return this;
        }

        public MyComplex divide(MyComplex right)
        {
            this.real = (double)((this.real * right.real + this.imag * right.imag) / (Math.Pow(right.real, 2) + Math.Pow(right.imag, 2)));
            this.imag -= (double)((this.imag * right.real - this.real * right.imag) / (Math.Pow(right.real, 2) + Math.Pow(right.imag, 2)));
            return this;
        }

        public MyComplex conjugate()
        {
            this.imag *= -1;
            return this;
        }

    }
}
