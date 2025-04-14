using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter13
{
    delegate int Compare(int a, int b);
    internal class UsingCallback
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int DesendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static void BubbleSort(int[] Dataset, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for ( i = 0; i < Dataset.Length; i++)
            {
                for ( j = 0; j < Dataset.Length - (i + 1); j++)
                {
                    if (Comparer(Dataset[j], Dataset[j+1]) > 0)
                    {
                        temp = Dataset[j + 1];
                        Dataset[j + 1] = Dataset[j];
                        Dataset[j] = temp;
                    }
                }
            }
        }

        static void MainUsingCallback()
        {
            int[] array = new int[] { 3, 7, 4, 2, 10 };
            Console.WriteLine("Sorting ascending");
            BubbleSort(array, new Compare(AscendCompare));

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            int[] array2 = new int[] { 7, 2, 8, 10, 11 };
            BubbleSort(array2, new Compare(DesendCompare));

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
    }
}
