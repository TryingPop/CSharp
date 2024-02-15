using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-7
 * 
 * out 키워드를 사용하는 메서드 생성
 */

namespace Book.Ch08
{
    internal class ex07
    {
        static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }

        static void Main7(string[] args)
        {
            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;

            Console.WriteLine($"현재 좌표 : ({x}, {y})");
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine($"다음 좌표 : ({x}, {y})");
        }
    }
}
