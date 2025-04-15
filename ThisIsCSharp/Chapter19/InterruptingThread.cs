using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter19
{
    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {
            try
            {
                Console.WriteLine("Running thread isn`t gonna be interrupted");
                Thread.Sleep(100);

                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Console.WriteLine("Entering into waitJoinSleep State..");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Clearing resource... ");
            }
        }
    }
    internal class InterruptingThread
    {
        static void MainInterruptingThread()
        {
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Starting Thread");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Interrupting THread");
            t1.Interrupt();

            Console.WriteLine("Wating until thread stop");
            t1.Join();


        }
    }
}
