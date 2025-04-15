using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter19
{
    internal class Async
    {
        async static private void MyMethodAsync(int count)
        {
            Console.WriteLine("C");
            Console.WriteLine("D");

            await Task.Run(async () =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"{i}/{count}");
                    await Task.Delay(100);
                }
            });

        }

        static void Caller()
        {
            Console.WriteLine("A");
            Console.WriteLine("b");
            MyMethodAsync(3);

            Console.WriteLine("E");
            Console.WriteLine("F");
        }
    }
}
