using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.AnimalAbstract
{
    public class Cat: Animal1
    {

        public Cat()
        {
        }

        public override string toString()
        {
            return $"Cat {this.toString()})";
        }

        public override void greeting()
        {
            Console.WriteLine("Meow!");
        }

    }
}
