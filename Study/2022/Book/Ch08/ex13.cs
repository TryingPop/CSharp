using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-13
 * 
 * 구조체의 초기화 형태
 */

namespace Book.Ch08
{
    internal class ex13
    {
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB;

            // 오버로딩
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.testA = "초기화";
                this.testB = "초기화";
            }

            // 오버로딩
            public Point(int x, int y, string test)
            {
                this.x = x;
                this.y = y;
                this.testA = test;
                this.testB = test;
            }
            //혹은 
            // public Point(int x, int y, string test) : this(x, y)
            // {
            //  this.testA = test;
            //  this.testB = test;
            // }
        }
        static void Main13(string[] args)
        {
        }
    }
}
