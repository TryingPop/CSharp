using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-10
 * 
 * 클래스 이름 충돌
 */

namespace Book.Ch05
{
    internal class ex10
    {
        // 기존에 있는 클래스 Math와 같은 이름의 클래스 생성
        // class Math { }

        static void Main10(string[] args)
        {
            // class Math { } 
            // 주석을 해제하면 Math 클래스를 이용할 수 없게 된다
            // 생성된 Math 클래스에 Abs 메서드가 없어서
            // 오류가 뜬다
            // 중복 안되는 이름 쓰기!
            Console.WriteLine(Math.Abs(-10));
        }
    }
}
