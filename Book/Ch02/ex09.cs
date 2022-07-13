using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-9
 * 
 * 정수와 실수
 */

namespace Book.Ch02
{
    internal class ex09
    {
        static void Main9(string[] args)
        {
            // 정수
            Console.WriteLine(0);

            // 실수
            // 0으로 표시된다
            Console.WriteLine(0.0);

            /*
            // 타입 확인하려면 아래 코드 주석 해제 후 실행
            object obj = 0.0;
            // 0으로 표기되나 double(실수) 형태로 나옴을 알 수 있다
            Console.WriteLine(obj.GetType().Name);
            */
        }
    }
}
