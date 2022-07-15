using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/* 날짜 : 2022.07.15
 * 내용 : 코드 4-33
 * 
 * 무한 반복하며 이동
 */

namespace Book.Ch04
{
    internal class ex33
    {
        static void Main33(string[] args)
        {
            bool state = true;

            while (state)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;

                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;

                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;

                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;

                    case ConsoleKey.X:
                        state = false;
                        break;
                }
            }
        }
    }
}
