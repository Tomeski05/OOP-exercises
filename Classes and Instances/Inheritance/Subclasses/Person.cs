using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Subclasses
{
    public class Person
    {
        private string name;
        private string address;

        public Person()
        {
        }

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public virtual string toString()
        {
            return "Person[" + "name=" + name + ",address=" + address + ']';
        }
    }
}
