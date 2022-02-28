using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.AnimalAbstract
{
    public class Dog: Animal
    {

        public Dog()
        {

        }

        public virtual string toString()
        {
            return $"Dog {this.toString()})";
        }

        public virtual void greeting()
        {
            Console.WriteLine("Woof!");
        }

        public virtual void greeting(Dog another)
        {
            Console.WriteLine("Woooooooooof!");
        }

    }
}
