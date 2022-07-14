using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 메서드 실습하기 교재 p256
 * 
 * 메서드(Method)
 *  - 일련의 코드 로직을 재활용하기 위해 모듈화된 구조체
 *  - 메서드는 정의(Define)하고 호출(Call)
 */

namespace Ch04
{
    internal class _1_메서드
    {
        static void Main1(string[] args)
        {
            // 메서드 호출
            int y1 = f(1);
            int y2 = f(2);
            int y3 = f(3);

            Console.WriteLine("y1 : {0}", y1);
            Console.WriteLine("y2 : {0}", y2);
            Console.WriteLine("y3 : {0}", y3);
            Console.WriteLine();

            Console.WriteLine("f(1) : {0}", f(1));

            int t1 = Sum(1, 10);
            int t2 = Sum(1, 100);
            int t3 = Sum(start: 1, end: 1000);


            Console.WriteLine("t1 : {0}", t1);
            Console.WriteLine("t2 : {0}", t2);
            Console.WriteLine("t3 : {0}", t3);

            Console.WriteLine();
            Console.WriteLine(Sum(2, 5));
            Console.WriteLine(Sum(5, 2));

            // 다른 타입, 혹은 초기값이 정의된 변수가 적으면 런타임 실행이 안된다
            // Console.WriteLine(Sum(2.0f, 3));
            
            // Console.WriteLine(Sum(3));


        } // end of Main

        // 메서드 정의
        // 접근권한이 먼저 설정하지만 생략 가능
        // 이 경우 public이 초기값으로 잡힌다 main에서는 생략
        // 이후 정적인지 동적인지 설정
        // void return값이 없다
        public static int f(int x)
        {
            int y = 2 * x + 3;
            return y;
        }

        // 메서드 정의2
        // 처음엔 무엇이 정의 될지 모르니 void로 선언하기
        // 추후에 return 타입을 알면 수정하기
        public static int Sum(int start, int end)
        {
            int result = 0;

            if (start <= end)
            {
                for (int k = start; k <= end; k++)
                {
                    result += k;
                }   
            }
            else
            {
                for (int k = end; k <= start; k++)
                {
                    result += k;
                }
            }
            return result;
        }
    }

}
