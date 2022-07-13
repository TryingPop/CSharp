using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-14
 * 
 * 이스케이프 문자
 */

namespace Book.Ch02
{
    internal class ex14
    {
        static void Main14(string[] args)
        {
            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            // 특수 키를 표현할 때 다음과 같이 이용한다
            // Python과 비슷
            Console.WriteLine("\"\"\"");
            Console.WriteLine("\\");
        }
    }
}
