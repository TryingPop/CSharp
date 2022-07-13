using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-24
 * 
 * 오버플로우
 */

namespace Book.Ch02
{
    internal class ex24
    {
        static void Main24(string[] args)
        {
            int a = 2147483640;
            int b = 52273;
            // int 값의 한계 때문에 정확한 값 표기 안된다.
            // 한단계 초과해서 음수가 표기되어버린다
            // 언더플로우라고 쓰는 경우도 있다
            Console.WriteLine(a + b);
        }
    }
}
