using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter09
{
    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} ${Amount}";
        }
    }
        internal class Record
    {
        static void MainRecord()
            {
            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = tr1 with { To = "Charlie" };
            RTransaction tr3 = tr2 with { From = "Dave", Amount = 30 };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);
        }
    }
}
