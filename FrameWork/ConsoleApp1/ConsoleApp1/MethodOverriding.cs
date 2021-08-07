using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combiner

{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes noise");
        }

        public override string ToString()
        {
            return "Animal is ovverriding ToString method of Object Class" ;
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("A dog barks... ");
        }
    }
    class Lion : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("A Lion roars... ");
        }
    }

    class Cat : Animal
    {
        public new void Speak() // with new keyword in the speak method we have achieved method hiding
        {
            Console.WriteLine("A cat mewos......");
        }
    }
    class MethodOverriding
    {
        static void Main()
        {
            Animal obj = new Animal(); //pure object of Animal class
            obj.Speak();
            Console.WriteLine(obj.ToString());

            Dog d = new Dog(); //pure object of dog class
            d.Speak();

            Animal obj1 = new Dog(); //impure object
            obj1.Speak();
            Console.WriteLine(obj1.ToString());

            Animal obb2 = new Lion();
            obb2.Speak();

            //Dog d1 = new Animal();

            Animal obb3 = new Cat();//run time polymorphism
            obb3.Speak();

            //obj.string();

            
            Console.Read();
        }
    }
}