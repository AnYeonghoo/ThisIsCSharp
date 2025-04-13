using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }

        public void MyMethod()
        {
            Console.WriteLine("Base Method");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }

        public new void MyMethod()
        {
            Console.WriteLine("Iron Man");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("DOuble-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher ARmed");
        }
    }
    internal class Override
    {
        static void MainOverride()
        {
            ArmorSuite armor = new ArmorSuite();
            armor.Initialize();
            armor.MyMethod();

            ArmorSuite iron = new IronMan();
            iron.Initialize();
            iron.MyMethod();

            ArmorSuite war = new WarMachine();
            war.Initialize();
        }
    }
}
