﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    internal class ArithmaticOperators
    {
        static void MainArithmaticOperators()
        {
            int a = 111 + 222;
            Console.WriteLine($"a: {a}");

            int b = a - 100;
            Console.WriteLine($"b: {b}");

            int c = b * 10;
            Console.WriteLine($"c: {c}");

            double d = c / 6.3;
            Console.WriteLine($"d: {d}");

            Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7}");
        }
    }
}
