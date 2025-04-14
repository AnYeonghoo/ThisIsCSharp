using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter10
{
    internal class _2DArray
    {
        static void Main_2DArray()
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}] : {arr[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}]: {arr[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
