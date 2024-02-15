using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 9-19
 * 
 * using 구문에서 StreamWriter 클래스의 인스턴스 생성
 */

namespace Book.Ch09
{
    internal class ex19
    {
        static void Main19(string[] args)
        {
            string path = @"C:test\test.txt";
            // StreamWriter 클래스를 추적해가면
            // IDisposable 인터페이스를 상속 받았음을 알 수 있다.
            // IDisposable을 상속받으면 using 구문으로 작성하는게 기본이다.
            // 메모리 관리에 도움이 된다
            using (StreamWriter writer = new StreamWriter(path))
            {

            }
        }
    }
}
