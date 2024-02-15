using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-56
 * 
 * 자료형 변환
 */

namespace Book.Ch02
{
    internal class ex56
    {
        static void Main56(string[] args)
        {
            // long 자료형을 int 자료형으로 변환
            long longNumber = 214783647L + 214783647L;
            // 아래 코드로 실행하면 오류 발생
            // 강제 자료형 변환 기법인 Casting 필요하다
            // int intNumber = longNumber;
        }
    }
}
