using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    internal class Switch
    {
        static void MainSwitch()
        {
            Console.WriteLine("요일을 입력하세요:  ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "일":
                    Console.WriteLine("Sunday");
                    break;
                case "월":
                    Console.WriteLine("Monday");
                    break;
                case "화":
                    Console.WriteLine("Tuesday");
                    break;
                case "수":
                    Console.WriteLine("Wednesdayt");
                    break;
                case "목":
                    Console.WriteLine("Thursday");
                    break;
                case "금":
                    Console.WriteLine("Firday");
                    break;
                case "토":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine($"{day}는 요일이 아닙니다.");
                    break;
            }
        }
    }
}
