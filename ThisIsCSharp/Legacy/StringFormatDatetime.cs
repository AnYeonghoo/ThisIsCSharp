﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    internal class StringFormatDatetime
    {
        static void MainStringFormatDatetime()
        {
            DateTime dt = new DateTime(2023, 03, 04, 23, 18, 22);

            Console.WriteLine("12시간 형식:  {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            Console.WriteLine("24시간 형식:  {0:yyyy-MM-dd tt hh:mm:ss (dddd)}", dt);


            CultureInfo ciKo = new CultureInfo("ko-KR");
            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)", ciKo));
            Console.WriteLine(dt.ToString(ciKo));

            CultureInfo ciEn = new CultureInfo("en-US");
            Console.WriteLine();
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)", ciEn));
            Console.WriteLine(dt.ToString(ciEn));
        }
    }
}
