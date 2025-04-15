using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter18
{
    internal class SeqNRand
    {
        static void MainSeqNRand()
        {
            Stream outStream = new FileStream("a.dat", FileMode.Create);

            outStream.WriteByte(0x01);
            outStream.WriteByte(0x02);
            outStream.WriteByte(0x03);
            outStream.Seek(0, SeekOrigin.Current);
            outStream.WriteByte(0x04);
            outStream.Close();
        }
    }
}
