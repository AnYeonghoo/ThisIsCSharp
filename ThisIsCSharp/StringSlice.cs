using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp
{
    internal class StringSlice
    {
        static void MainStringSlice()
        {
            string greeting = "Good morning.";
            Console.WriteLine(greeting.Substring(0, 5));
            Console.WriteLine(greeting.Substring(5));
            Console.WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);
            Console.WriteLine(arr.Length);

            foreach (string element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
