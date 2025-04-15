using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter18
{
    internal class BinaryFile
    {
        static void MainBinaryFile()
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create)))
            {
                bw.Write(int.MaxValue);
                bw.Write("Good morning");
                bw.Write(uint.MaxValue);
                bw.Write(double.MaxValue);
                bw.Write("Hi");
            }

            using BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));

            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.BaseStream.Length);
        }
    }
}
