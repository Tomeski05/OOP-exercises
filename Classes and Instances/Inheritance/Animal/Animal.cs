using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Animal
{
    public class Animal
    {
        public string name;

        public Animal()
        {

        }

        public Animal(string name)
        {
            this.name = name;
        }

        public virtual string toString()
        {
            return $"Animal name {name}";
        }

    }
}
