using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-11
 * 
 * 구조체의 생성자
 */

namespace Book.Ch08
{
    internal class ex11
    {
        struct Point
        {
            public int x;
            public int y;
            
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main11(string[] args)
        {
            Point point = new Point();
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }
}
