using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter19
{
    internal class AsyncFileIO
    {
        static async Task<long> CopyAsync(string FromPath, string ToPath)
        {
            using (var fromStream = new FileStream(FromPath, FileMode.Open))
            {
                long totalCopied = 0;

                using (var toStream = new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    int nRead = 0;

                    while ((nRead = await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;
                    }
                }
                return totalCopied;
            }
        }
    }
}
