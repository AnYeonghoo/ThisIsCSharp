using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter18
{
    internal class Dir
    {
        static void MainDir(string[] args)
        {
            string directory;
            if (args.Length < 1)
            {
                directory = ".";
            }
            else
            {
                directory = args[0];
            }
            
            var directories = (from dir in Directory.GetDirectories(directory)
                               let info = new DirectoryInfo(dir)
                               select new
                               {
                                   Name = info.Name,
                                   Attributes = info.Attributes
                               }
                               ).ToList();

            foreach (var d in directories)
            {
                Console.WriteLine($"{d.Name} : {d.Attributes}");

            }

            var files = (from file in Directory.GetFiles(directory)
                         let info = new FileInfo(file)
                         select new
                         {
                             Name = info.Name,
                             FileSize = info.Length,
                             Attributes = info.Attributes,
                         }).ToList();
            foreach (var f in files)
            {
                Console.WriteLine(f.Name);
            }
        }
    }
}
