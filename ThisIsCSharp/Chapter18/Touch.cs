using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter18
{
    internal class Touch
    {
        static void OnWrongPathType(string type)
        {
            Console.WriteLine($"{type} is wrong type");
            return;
        }

        static void MainTouch(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage : Touch.exe <Path> [Type:File/Directory]");
                return;
            }

            string path = args[0];
            string type = "File";
            if (args.Length > 1)
            {
                type = args[1];
            }

            if (File.Exists(path) || Directory.Exists(path))
            {
                if (type == "File")
                {
                    File.SetLastWriteTime(path, DateTime.Now);
                }
                else if (type == "Directory")
                {
                    Directory.SetLastWriteTime(path, DateTime.Now);
                }
                else
                {
                    OnWrongPathType(type);
                    return;
                }

            }
            else
            {
                if (type == "File")
                {
                    File.Create(path).Close();
                }
                else if (type == "Directory")
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    OnWrongPathType(type);
                    return;
                }
            }
        }
    }
}
