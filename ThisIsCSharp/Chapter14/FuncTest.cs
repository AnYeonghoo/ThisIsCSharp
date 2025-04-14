using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter14
{
    internal class FuncTest
    {
        static void MainFuncTest()
        {
            Func<int> fun1 = () => 10;
            Func<int, int> fun2 = (x) => x * 2;
            Func<double, double, double> fun3 = (x, y) => x / y;
        }
    }
}
