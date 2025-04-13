using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    class Cat
    {
        public string Name;
        public string Color;
        public void Meow()
        {
            Console.WriteLine($"{Name} Meow!");
        }
    }
    internal class BasicClass
    {
        static void MainBasicClass()
        {
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
