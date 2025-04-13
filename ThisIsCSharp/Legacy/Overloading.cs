using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    internal class Overloading
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }

        // Overloading
        static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Plus(double a, double b)
        {
            return a + b;
        }

        static double Plus(int a, double b)
        {
            return a + b;
        }

        static void MainOverloading()
        {

        }
    }
}
