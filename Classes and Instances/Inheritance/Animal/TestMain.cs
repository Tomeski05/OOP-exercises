using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Animal
{
    public class TestMain
    {
        static void Main(string[] args)
        {
            Mammal myMammal = new Mammal();
            myMammal.name = "Bob";
            Console.WriteLine(myMammal.toString());

            Cat myCat = new Cat();
            myCat.name = "kitty";
            myCat.greets();
            Console.WriteLine(myCat.toString());

            Dog myDog = new Dog();
            Dog anotherDog = new Dog();
            anotherDog.name = "Sparky";
            Console.WriteLine(anotherDog.toString());
            myDog.name = "Doggo";
            myDog.greets();
            myDog.greets(anotherDog);
            Console.WriteLine(myDog.toString());
            

            Console.ReadLine();

        }
    }
}
