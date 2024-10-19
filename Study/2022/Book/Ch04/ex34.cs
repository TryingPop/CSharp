using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 4-34
 * 
 * @이동
 */

namespace Book.Ch04
{
    internal class ex34
    {
        static void Main34(string[] args)
        {
            bool state = true;
            int x = 0;
            int y = 0;

            while (state)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        y -= 1;
                        if (y < 0)
                        {
                            y = 0;
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        x += 1;
                        break;

                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        y += 1;
                        break;

                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        x -= 1;
                        if (x < 0)
                        {
                            x = 0;
                        }
                        break;

                    case ConsoleKey.X:
                        state = false;
                        break;
                }
                Console.SetCursorPosition(x, y);
                Console.Write("@");
            }
        }
    }
}
