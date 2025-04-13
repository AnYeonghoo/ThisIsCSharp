using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    internal class StringFormatBasic
    {
        static void MainStringFormatBasic()
        {
            string fmt = "{0,-20}{1,-15}{2,30}";

            Console.WriteLine(fmt, "Publisher", "Author", "Title");
            Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
        }
           
    }
}
