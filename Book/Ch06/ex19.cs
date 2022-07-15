using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-19
 * 
 * 정적 생성자
 */

namespace Book.Ch06
{
    internal class ex19
    {
        class Sample
        {
            public static int value;

            // 한 번만 호출된다
            // 접근 제한자를 사용하지 못한다
            // 매개변수를 사용하지 못한다
            static Sample()
            {
                value = 10;
                Console.WriteLine("정적 생성자 호출");
            }
        }
    }
}
