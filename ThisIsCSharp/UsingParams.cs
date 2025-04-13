using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp
{
    internal class UsingParams
    {
        static int Sum(params int[] args)
        {
            int sum = 0;
            for (int i = 0; i <args.Length; i++)
            {

                sum += args[i];
            }
            return sum;
        }

        static void MainUsingParams()
        {
            int sum = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine(sum);
        }
    }
}
