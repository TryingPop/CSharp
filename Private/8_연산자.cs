using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.08.01
 * 내용 : 연산자 - ?, ??=
 */

namespace Private
{
    internal class _8_연산자
    {
        static void Main8(string[] args)
        {
            Example ex = new Example();
            
            var chk1 = ex?.x?[0];
            // ex.y에서 null 이라 나머지 항목 체크 없이 null로 반환
            var chk2 = ex?.y?[1];

            if (chk1 == null)
            {
                Console.WriteLine("ex.x[0] : null");
            }
            if (chk2 == null)
            {
                // 실상은 ex.y == null
                Console.WriteLine("ex.y[1] : null");
            }

            List<int> number = null;
            int? a = null;

            (number ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", number));


            int? b = (a ??= null);
            Console.WriteLine(b);

            b = (b ??= 8);
            Console.WriteLine(b);
        }

        class Example 
        {
            public string[] x = { null, "a" };
            public string[] y = null;
        }

    }
}

// 참고 사이트
// https://velog.io/@jinuku/C-%EB%B0%8F-.-%EC%97%B0%EC%82%B0%EC%9E%90

// C# 8.0 이상부터 ?? 및 ??= 연산자의 왼쪽 피연사자
// 형식은 null을 허용하지 않는 값 형식일 수 없다
// C# 8.0부터 비제한 형식 매개 변수와 함께 null 병합 연산자를 사용할 수 있따.