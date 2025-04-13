using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter08
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMethodA();
    }

    class Derived2 : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived2.AbstreactMethodA()");
            PrivateMethodA();
        }
    }

    internal class AbstractClass
    {
    }
}
