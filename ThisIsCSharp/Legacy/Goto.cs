﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    internal class Goto
    {
        static void MainGoto()
        {
            Console.Write("종료 조건을 입력하세요: ");
            string input = Console.ReadLine();
            int inputNumber = Convert.ToInt32(input);
            int exitNumber = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (exitNumber++ == inputNumber)
                        {
                            goto EXIT_FOR;
                        }
                        Console.WriteLine(exitNumber);
                    }
                }
            }
            goto EXIT_PROGRAM;

        EXIT_FOR:
            Console.WriteLine("\nExit nested for...");

        EXIT_PROGRAM:
            Console.WriteLine("Exit program..");
        }
    }
}
