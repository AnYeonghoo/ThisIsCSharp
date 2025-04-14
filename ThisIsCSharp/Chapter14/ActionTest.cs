using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter14
{
    internal class ActionTest
    {
        static void MainActionTest()
        {
            Action act1 = () => Console.WriteLine("Action");
            int result = 0;
            Action<int> act2 = (x) => result = x * x;

            Action<double, double> act3 = (x, y) =>
            {
                double pi = x / y;
                Console.WriteLine(pi);
            };
        }
    }
}
