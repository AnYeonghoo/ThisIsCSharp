using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter16
{
    class MyClass
    {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 사용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine("Im Old");
        }
        public void NewMethod()
        {
            Console.WriteLine("Im New");
        }
    }
    internal class BasicAttribute
    {
        static void MainBasicAttribute()
        {

        }
    }
}
