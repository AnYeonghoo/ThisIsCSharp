using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter12
{
    class InvalidArgumentException : Exception
    {
        public InvalidArgumentException() { }

        public InvalidArgumentException(string message) : base(message)
        {

        }

        public object Argument { get; set; }
        public object Range { get; set; }

    }
    internal class MyException
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new int[] { alpha, red, green, blue };
            foreach (uint arg in args)
            {
                if (arg > 255)
                {
                    throw new InvalidArgumentException()
                    {
                        Argument = arg,
                        Range = "0~255"
                    };
                }

                return (alpha << 24 & 0xFF000000) |
                    (red << 16 & 0x00FF0000) |
                    (green << 8 & 0x0000FF00) |
                    (blue & 0x000000FF);
            }

        }
        static void MainMyException()
        {

        }
    }
}
