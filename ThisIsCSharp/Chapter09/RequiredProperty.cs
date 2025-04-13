using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter09
{
    class BirthdayInfo3
    {
        public required string Name { get; set; }
        public required DateTime Birthday { get; init; }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    internal class RequiredProperty
    {
    }
}
