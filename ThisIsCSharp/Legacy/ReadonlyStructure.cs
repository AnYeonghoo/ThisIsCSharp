using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    readonly struct RGBColor
    {
        public readonly byte R;
        public readonly byte G;
        public readonly byte B;

        public RGBColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

    }
    internal class ReadonlyStructure
    {
    }
}
