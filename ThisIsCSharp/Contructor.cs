using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp
{
    class Cat2
    {

        public Cat2()
        {
            this.Name = "";
            this.Color = "";
        }
        public Cat2(string Name, string Color)
        {
            this.Name = Name;
            this.Color = Color;
        }

        public string Name;
        public string Color;

        ~Cat2()
        {
            Console.WriteLine($"{Name} 잘가");
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} Meow!");
        }
    }
    internal class Contructor
    {
    }
}
