using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter09
{
    internal class AnonymousType
    {
        static void MainAnonymousType()
        {
            var a = new { Name = "박상현", Age = 123 };
            Console.WriteLine($"{a.Name}, {a.Age}");

            var b = new { Subject = "수학", Socres = new int[] { 90, 80, 70, 60 } };
            Console.Write($"Subject: {b.Subject} Socre: ");
            foreach (var score in  b.Socres)
            {
                Console.Write($"{score}");
            }
            Console.WriteLine();
        }
    }
}
