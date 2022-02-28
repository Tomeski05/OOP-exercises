using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism__Abstract_Classes_and_Interfaces.AnimalAbstract
{
    public class BigDog: Dog
    {

        public BigDog()
        {

        }

        public string toString()
        {
            return "BigDog[" + this.toString() + ']';
        }

        public override void greeting()
        {
            Console.WriteLine("Woow!");
        }
    
        public override void greeting(Dog another)
        {
            Console.WriteLine("Woooooowwwww!");
        }
    }
}
