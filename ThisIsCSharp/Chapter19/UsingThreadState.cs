using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter19
{
    internal class UsingThreadState
    {
        private static void PrintThreadState(ThreadState state)
        {
            Console.WriteLine($"{state} : {(int)state}");
        }

        static void MainUsingThreadState()
        {
            PrintThreadState(ThreadState.Running);
            PrintThreadState(ThreadState.StopRequested);
            PrintThreadState(ThreadState.SuspendRequested);
            PrintThreadState(ThreadState.Background);
            PrintThreadState(ThreadState.Unstarted);
            PrintThreadState(ThreadState.Stopped);
        }
    }
}
