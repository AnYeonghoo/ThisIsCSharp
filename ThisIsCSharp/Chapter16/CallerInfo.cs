using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter16
{
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file ="",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member= "")
        {
            Console.WriteLine($"{file}(line:{line} : {message}");
        }
    }
    internal class CallerInfo
    {
        static void MainCallerInfo()
        {
            Trace.WriteLine("즐거운");
        }
    }
}
