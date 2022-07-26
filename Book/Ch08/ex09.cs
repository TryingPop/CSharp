using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-9
 * 
 * 구조체에는 매개변수 없는 생성자 선언 불가능
 */

namespace Book.Ch08
{
    internal class ex09
    {
        struct Point
        {
            public int x;
            public int y;
            
            /*
            // 변수 없는 생성자 선언 불가능
            public Point()
            {

            }
            */
        }

        static void Main9(string[] args)
        {
        }
    }
}
