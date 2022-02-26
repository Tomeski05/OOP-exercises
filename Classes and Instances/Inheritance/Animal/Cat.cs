using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Animal
{
    public class Cat: Mammal
    {
        public Cat()
        {

        }

        public Cat(string name)
        {
            this.name = name;
        }

        public void greets()
        {
            Console.WriteLine("Meow");
        }

        public override string toString()
        {
            return $"Cat name {name}";
        }
    }
}