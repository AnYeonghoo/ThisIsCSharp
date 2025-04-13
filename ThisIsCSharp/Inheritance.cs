using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }

        ~Base()
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethod()");
        }
    }

    class Derived : Base
    {
        public Derived(string name) : base(name)
        {
            Console.WriteLine($"{this.Name}.Derived");
        }

        ~Derived()
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }
    }
    internal class Inheritance
    {

    }
}
