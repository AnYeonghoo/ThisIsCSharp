﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter15
{
    internal class From
    {
        static void MainFrom()
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };
            var result = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;
            foreach (var n in result)
                Console.WriteLine(n);
        }
    }
}
