using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter11
{
    class Mylist<T>
    {
        private T[] array;
        public Mylist()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index > array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized: {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
    }
    internal class Generic
    {
    }
}
