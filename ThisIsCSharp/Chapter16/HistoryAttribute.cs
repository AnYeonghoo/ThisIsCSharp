using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter16
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple =true)]
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }
    }

    [History("Sean", version = 0.1, changes = "2017-11-01 Created class stub")]
    [History("Bob", version =0.2, changes ="2020-12-03 Added Func() Method")]
    class MyClass2
    {
        public void Func()
        {
            Console.WriteLine("Func");
        }
    }
    internal class HistoryAttribute
    {
    }
}
