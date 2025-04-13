using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    internal class ShiftOperator
    {
        static void MainShiftOperator()
        {
            int a = 1;

            Console.WriteLine("a   : {0:D5} (0x{0:X8})", a);
            Console.WriteLine("a >> 1 : {0:D5} (0x{0:X8})", a << 1);
            Console.WriteLine("a >> 2 : {0:D5} (0x{0:X8})", a << 2);
            Console.WriteLine("a >> 5 : {0:D5} (0x{0:X8})", a << 5);
        }
    }
}
