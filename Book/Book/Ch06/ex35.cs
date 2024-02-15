using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 6-35
 * 
 * 재귀 메서드를 사용한 피보나치 인스턴스 메서드
 */

namespace Book.Ch06
{
    internal class ex35
    {
        class Fibonacci
        {
            // Fibonacci는 급격하게 커지므로 long을 이용
            public long Get(int i)
            {
                // if, else if 부분이 종료 조건
                if (i < 0)
                {
                    return 0;
                }
                else if (i == 1)
                {
                    return 1;
                }
                else
                {
                    return Get(i - 2) + Get(i - 1);
                }
            }
        }

        static void Main35(string[] args)
        {
            Fibonacci fibo = new ex35.Fibonacci();
            Console.WriteLine(fibo.Get(1));
            Console.WriteLine(fibo.Get(2));
            Console.WriteLine(fibo.Get(3));
            Console.WriteLine(fibo.Get(4));
            Console.WriteLine(fibo.Get(5));
        }
    }
}