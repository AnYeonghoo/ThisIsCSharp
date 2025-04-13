using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine($"Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark() { }
    }

    class Cat3 : Mammal
    {
        public void Meow() { }
    }
    internal class TypeCasting
    {
        static void MainTypeCasting()
        {
            Mammal mammal = new Dog();
            Dog dog;

            if (mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat3();
            Cat3 cat = mammal2 as Cat3;
            if (cat != null)
            {
                cat.Meow();
            }


        }
    }
}
