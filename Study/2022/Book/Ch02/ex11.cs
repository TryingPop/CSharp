using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-11
 * 
 * 실수와 나머지 연산자
 */

namespace Book.Ch02
{
    internal class ex11
    {
        static void Main11(string[] args)
        {
            // 앞의 부호와 같은 나머지를 찾는다
            // 실수형은 정확한 값을 못 산정하기에 약간의 오차가 있을 수 있다
            Console.WriteLine(5.0 % 2.2);
        }
    }
}
