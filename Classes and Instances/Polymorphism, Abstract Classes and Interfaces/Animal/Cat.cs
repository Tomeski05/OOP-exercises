using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.Animal
{
    public class Cat : Animal
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public Cat()
        {
        }

        public string toString()
        {
            return "Cat[" + this.toString() + ']';
        }

        public void greets()
        {
            Console.WriteLine("Meow");
        }
    }

}
