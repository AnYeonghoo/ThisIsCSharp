using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FS = System.IO.FileStream;

namespace ThisIsCSharp.Chapter18
{
    internal class UsingDeclaration
    {
        static void UsingDeclarationMain()
        {
            long someValue = 0x123456789ABCDEF0;

            using (Stream outStream = new FS("a.dat", FileMode.Create))
            {
                byte[] wBytes = BitConverter.GetBytes(someValue);
                foreach (byte b in wBytes)
                {
                    Console.WriteLine(b);
                }
                outStream.Write(wBytes, 0, wBytes.Length);
            }

            using Stream inStream = new FS("a.dat", FileMode.Open);
            byte[] rBytes = new byte[8];

            int i = 0;
            while (inStream.Position < inStream.Length)
            {
                rBytes[i++] = (byte)inStream.ReadByte();
            }

            long readValue = BitConverter.ToInt64(rBytes, 0);

        }
    }
}
