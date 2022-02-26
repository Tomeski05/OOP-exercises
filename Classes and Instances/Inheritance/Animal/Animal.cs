using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Animal
{
    public class Animal
    {
        private string name;

        public Animal()
        {

        }

        public Animal(string name)
        {
            this.name = name;
        }

        public string toString()
        {
            return $"Animal name {name}";
        }

    }
}
