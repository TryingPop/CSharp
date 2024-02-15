using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-10
 * 
 * 구조체의 생성자
 */

namespace Book.Ch08
{
    internal class ex10
    {
        struct Point
        {
            public int x;
            public int y;
            
            // int x, int y 둘 중 하나라도 빠지면 생성자를 못만든다
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main10(string[] args)
        {
        }
    }
}
