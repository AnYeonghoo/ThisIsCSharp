﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    internal class IfEls
    {
        static void MainIfEls()
        {
            Console.Write("숫자를 입력하세요: ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number < 0)
            {
                Console.WriteLine("음수");
            }
            else if (number > 0)
            {
                Console.WriteLine("양수");
            }
            else
            {
                Console.WriteLine("0");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }
        }
    }
}
