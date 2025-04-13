using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp
{
    internal class VarPattern
    {
        static void MainVarPattern()
        {
            var IsPassed =
                (int[] scores) => scores.Sum() / scores.Length is var average
                && Array.TrueForAll(scores, (score) => score >= 60)
                && average >= 60;

            int[] scores1 = { 90, 80, 60, 80, 70 };
            Console.WriteLine($"{string.Join(",", scores1)} : Pass: {IsPassed(scores1)}");

        }
    }
}
