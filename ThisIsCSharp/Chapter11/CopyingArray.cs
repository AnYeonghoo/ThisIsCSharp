using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter11
{
    internal class CopyingArray
    {
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        static void MainCopyingArray()
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);
            foreach (int elem in target)
                Console.WriteLine(elem);

            string[] source1 = { "하나", "둘", "셋", "넷" };
            string[] target1 = new string[source1.Length];

            CopyArray<string>(source1, target1);
            foreach (string ele in target1) Console.WriteLine(ele);
        }
    }
}
