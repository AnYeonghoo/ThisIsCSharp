using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter10
{
    internal class InitializingCollections
    {
        static void MainInitializingCollections()
        {
            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            foreach (object item in list)
                Console.WriteLine($"Arraylist: {item}");
            Console.WriteLine();

            Stack stack = new Stack(arr);
            foreach (object item in stack)
                Console.WriteLine($"Stack: {item}");
            Console.WriteLine();

            Queue queue = new Queue(arr);
            foreach (object item in queue)
                Console.WriteLine($"Queue: {item}");
            Console.WriteLine();

            
        }
    }
}
