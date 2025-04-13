using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    internal class Return
    {
        static int Fibo(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibo(n - 1) + Fibo(n - 2);
        }

        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해주세요");
                return;
            }
            Console.WriteLine($"Name: {name}, Phone : {phone}");
        }
        static void MainReturn()
        {

        }
    }
}
