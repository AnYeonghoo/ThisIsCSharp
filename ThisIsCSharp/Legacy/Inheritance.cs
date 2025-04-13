using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
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
            Console.WriteLine($"{Name}.~Base()");
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
            Console.WriteLine($"{Name}.Derived");
        }

        ~Derived()
        {
            Console.WriteLine($"{Name}.Derived()");
        }
    }
    internal class Inheritance
    {

    }
}
