using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/* 날짜 : 2022.07.15
 * 내용 : 코드 4-32
 * 
 * 이동하는 달팽이
 */

namespace Book.Ch04
{
    internal class ex32
    {
        static void Main32(string[] args)
        {
            int x = 1;
            while (x < 50)
            {
                // 화면창 초기화
                Console.Clear();

                Console.SetCursorPosition(x, 5);

                if (x%3 == 0)
                {
                    Console.WriteLine("__@");
                }
                else if (x%3 == 1)
                {
                    Console.WriteLine("_^@");
                }
                else
                {
                    Console.WriteLine("^_@");
                }
                Thread.Sleep(100);
                x++;
            }
        }

    }
}
