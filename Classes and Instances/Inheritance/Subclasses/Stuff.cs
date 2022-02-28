using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Subclasses
{
    public class Stuff: Person
    {
        private string school;
        private double pay;

        public Stuff(string name, string address, string school, double pay)
        {
            //this.(name, address);
            this.school = school;
            this.pay = pay;
        }

        public string getSchool()
        {
            return school;
        }

        public void setSchool(string school)
        {
            this.school = school;
        }

        public double getPay()
        {
            return pay;
        }

        public void setPay(double pay)
        {
            this.pay = pay;
        }

        public override string  toString()
        {
            return $"Staff + {this.toString()}, school = {school}, pay = + {pay})";
        }


    }
}
