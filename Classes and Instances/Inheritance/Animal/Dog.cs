using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Animal
{
    public class Dog: Mammal
    {
        public Dog()
        {

        }

        public Dog(string name)
        {
            this.name = name;
        }

        public void greets()
        {
            Console.WriteLine("Woof");
        }

        public void greets(Dog another)
        {
            Console.WriteLine("Woooof");
        }

        public override string toString()
        {
            return $"Dog name {name}";
        }
    }
}
