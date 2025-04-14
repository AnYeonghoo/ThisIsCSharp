using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter10
{
    class MEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            yield return numbers[3];
        }
    }
    internal class MyEnumerator
    {
    }
}
