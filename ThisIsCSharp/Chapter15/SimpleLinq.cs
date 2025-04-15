using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter15
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    internal class SimpleLinq
    {
        static void MainSimpleLinq()
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "2", Height = 158 },
                new Profile() { Name = "3", Height = 172 },
                new Profile() { Name = "4", Height = 178 },
                new Profile() { Name = "5", Height = 171 }
            };

            var profiles = from profile in arrProfile
                           where profile.Height < 175
                           orderby profile.Height ascending
                           select new
                           {
                               Name = profile.Name,
                               Height = profile.Height
                           };

            foreach (var profile in profiles)
            {
                Console.WriteLine($"{profile.Name} : {profile.Height}");
            }
        }
    }
}
