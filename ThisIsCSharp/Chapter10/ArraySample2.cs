using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter10
{
    internal class ArraySample2
    {
        static void MainArraySample2()
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 81;
            scores[2] = 82;
            scores[3] = 83;
            scores[4] = 84;

            Console.WriteLine(scores[^2]);
        }
    }
}
