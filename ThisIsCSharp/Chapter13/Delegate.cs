using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter13
{
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b) { return a + b; }
        public int Minus(int a, int b) { return a - b; }
    }
    internal class Delegate
    {
        static void MainDelegate()
        {
            Calculator cal = new Calculator();
            MyDelegate callback;

            callback = new MyDelegate(cal.Plus);
            Console.WriteLine(callback(1, 3));

            callback = new MyDelegate(cal.Minus);
            Console.WriteLine(callback(4, 2));
            return;
        }
    }
}
