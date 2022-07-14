using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 메서드 지역변수 실습하기 교재 p275
 * 
 * 전역 변수(Global Variable) 
 *  - 모든 메서드에서 참조할 수 있는 변수
 *  - 객체지향프로그래밍에서 전역 변수는 멤버변수(속성) 이다.
 * 
 * 지역 변수(Local Variable)
 *  - 특정 메서드에서 선언한 변수로 해당 메서드에서만 참조한다.
 *  - 해당 메서드가 끝나면 Stack에서 사라진다.(Pop)
 */

namespace Ch04
{
    internal class _4_메서드_지역변수
    {
        // 전역 변수
        static int result = 0;

        static void Main4(string[] args)
        {    
            // 지역 변수
            int n1 = 1;
            int n2 = 10;

            result = Sum(n1, n2);
            Console.WriteLine(n1);
            Console.WriteLine("result : {0}", result);
        } // end of Main


        // 메서드의 매개변수도 지역변수
        public static int Sum(int start, int end)
        {
            int n1 = 0;
            Console.WriteLine(n1);
            int total = 0;
            if (start <= end)
            {
                for (int k = start; k <= end; k++)
                {
                    total += k;
                }
            }
            else
            {
                for (int k = end; k <= start; k++)
                {
                    total += k;
                }
            }
            return total;
        }
    }
}
