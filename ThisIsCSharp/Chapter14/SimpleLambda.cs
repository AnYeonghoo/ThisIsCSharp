using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter14
{
    delegate int Calculate(int a, int b);
    internal class SimpleLambda
    {
        static void MaiSimpleLambdan()
        {
            Calculate cal = (a, b) => a + b;
            Console.WriteLine(cal(3, 4));
        }
    }
}
