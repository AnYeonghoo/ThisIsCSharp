using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter10
{
    internal class JaggedArray
    {
        static void MainJaggedArray()
        {
            int[][] jaaged = new int[3][];
            jaaged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jaaged[1] = new int[] { 10, 20, 30 };
            jaaged[2] = new int[] { 100, 200 };

            foreach (int[] arr in jaaged)
            {
                Console.Write($"Length: {arr.Length}, ");
                foreach(int e in arr)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[][] jagged2 = new int[2][]
            {
                new int[] {1000, 2000 },
                new int[4] {6, 7, 8, 9 },
            };

            foreach (int[] arr in jagged2)
            {
                Console.Write($"Length: {arr.Length}");
                foreach (int e in arr)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine();
            }
        }
    }
}
