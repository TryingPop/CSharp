using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-18
 * 
 * Private 생성자
 */

namespace Book.Ch06
{
    internal class ex18
    {
        class Hidden
        {
            // 생성시 자동 실행되는 구문
            // Python에서
            // 클래스명.__init__(self)
            // 과 동일하다
            private Hidden() { }
        }

        static void Main18(string[] args)
        {
            // 오류나는 구문
            // Hidden 생성에 모순
            // 생성 시작시 private로 걸려버린다
            // Hidden hidden = new Hidden();
        }
    }
}
