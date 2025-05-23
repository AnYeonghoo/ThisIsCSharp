﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    internal class LocationPattern
    {
        struct Audience
        {
            public bool IsCitizen { get; init; }
            public int Age { get; init; }

            public Audience(bool isCitizen, int age)
            {
                IsCitizen = isCitizen;
                Age = age;
            }

            public void Deconstruct(out bool isCitizen, out int age)
            {
                isCitizen = IsCitizen;
                age = Age;
            }
        }
        static void MainLocationPattern()
        {
            Tuple<string, int> itemPrice = new Tuple<string, int>("espresso", 3000);
            var CalcuateFee = (Audience audience) => audience switch
            {
                (true, < 19) => 100,
                (true, _) => 200,
                (false, < 19) => 200,
                (false, _) => 400,
            };

            var a1 = new Audience(true, 10);
            Console.WriteLine(
                $"내국인 : {a1.IsCitizen} 나이 : {a1.Age} 요금: {CalcuateFee(a1)}");
        }
    }
}
