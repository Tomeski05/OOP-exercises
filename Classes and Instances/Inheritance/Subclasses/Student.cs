using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Subclasses
{
    public class Student: Person
    {
        private string program;
        private int year;
        private double fee;

        public Student(string name, string address, string program, int year, double fee)
        {
            //this.(name, address);
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public Student(string program, int year, double fee, string name, string address)
        {
            //this.(name, address);
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public string getProgram()
        {
            return program;
        }

        public void setProgram(string program)
        {
            this.program = program;
        }

        public int getYear()
        {
            return year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public double getFee()
        {
            return fee;
        }

        public void setFee(double fee)
        {
            this.fee = fee;
        }

        public override string toString()
        {
            return $"Student + {this.toString()} ,program = {program} ,year ={year},fee = + {fee})";
        }
}
}
