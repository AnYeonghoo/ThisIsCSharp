using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter18
{
    internal class BasicIO
    {
        static void MainBasicIO(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;

            Stream outStream = new FileStream("a.dat", FileMode.Create);
            byte[] wBytes = BitConverter.GetBytes(someValue);

            foreach (byte b in wBytes)
            {
                
            }

            outStream.Write(wBytes, 0, wBytes.Length);
            outStream.Close();
            
            Stream inStream = new FileStream("a.dat", FileMode.Open);
            byte[] rbytes = new byte[8];
            int i = 0;
            while (inStream.Position < inStream.Length)
            {
                rbytes[i++] = (byte)inStream.ReadByte();
            }

            long readValue = BitConverter.ToInt64(rbytes, 0);

            inStream.Close();

        }
    }
}
