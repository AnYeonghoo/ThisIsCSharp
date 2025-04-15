using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter15
{
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }
    internal class FromFrom
    {
        static void MainFromFrom()
        {
            Class[] arrClass =
            {
                new Class(){Name="1", Score = new int[]{99,88,70,24}},
                new Class(){Name="2", Score= new int[] {65, 45, 87, 72}},
                new Class(){Name="3", Score=new int[]{92, 30, 85, 94}}
            };
            var classes = from c in arrClass
                          from s in c.Score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = 5 };

            foreach (var c in classes)
            {
                Console.WriteLine($"{c.Name} : {c.Lowest}");
            }
        }
    }
}
