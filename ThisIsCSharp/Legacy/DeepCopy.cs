using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;
        int a, b, c;

        public MyClass()
        {
            a = 5425;

        }

        public MyClass(int b) : this()
        {
            this.b = b;
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
        }
        public MyClass DeepCopy()
        {
            MyClass newClass = new MyClass();
            newClass.MyField1 = MyField1;
            newClass.MyField2 = MyField2;
            return newClass;
        }
    }
    internal class DeepCopy
    {
    }
}
