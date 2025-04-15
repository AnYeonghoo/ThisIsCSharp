using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter19
{
    internal class BasicThread
    {
        static void Do()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Do: {i}");
                Thread.Sleep(10);
            }
        }
        static void MainBasicThread()
        {
            Thread t1 = new Thread(new ThreadStart(Do));
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(10);
            }

            t1.Join();

        }
    }
}
