using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-12
 * 
 * 구조체는 생성자에서 모든 변수를 초기화해야 함
 */

namespace Book.Ch08
{
    internal class ex12
    {
        struct Point
        {
            public int x;
            public int y;

            
            // public string testA; // testA값이 초기화 안되서 생성자에 오류가 뜬다
            // public string testB = "init"; // testB에 값이 있어서 나머지 값도 전부 초기화 해줘야한다.

            /*
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            */
        }

        static void Main12(string[] args)
        {
            
        }
    }
}
