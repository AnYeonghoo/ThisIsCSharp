using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter19
{
    internal class UsingTask
    {
        static void MainUsingTask(string[] args)
        {
            string srcFile = args[0];

            Action<object> FileCopyAction = (object state) =>
            {
                String[] paths = (String[])state;
                File.Copy(paths[0], paths[1]);


            };

            Task t1 = new Task(
                FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });

            Task t2 = Task.Run(() =>
            {
                FileCopyAction(new string[] { srcFile, srcFile + ".copy2" }); ;

            });

            t1.Start();

            Task t3 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy3" });
            t3.RunSynchronously();
            t1.Wait();
            t2.Wait();
            t3.Wait();

        }
    }
}
