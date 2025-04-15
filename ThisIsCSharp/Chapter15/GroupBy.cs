using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter15
{
    class Profiles
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    internal class GroupBy
    {
        static void MainGroupBy()
        {
            Profiles[] arrProfile =
            {
                new Profiles(){Name="1", Height=186},
                new Profiles() {Name="2", Height=158}
            };

            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiless = g };
            foreach (var Group in listProfile)
            {

            }

        }
    }
}
