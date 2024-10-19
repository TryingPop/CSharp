using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-16
 * 
 * 클래스 변수 생성과 사용
 */

namespace Book.Ch05
{
    internal class ex16
    {
        class MyMath
        {
            public static double PI = 3.141592;
        }

        static void Main16(string[] args)
        {
            Console.WriteLine(MyMath.PI);
            // 인스턴스 변수에 static이 없는 경우 static 필드나 참조할게 필요하다
            // 즉
            // MyMath mymath = new MyMath();
            // Console.WriteLine(mymath.PI);
            // 코드 입력이 필요하다
        }
    }
}
