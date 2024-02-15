using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 반복문 while 실습하기 교재 p162
 * 
 */

namespace Ch03
{
    internal class _4_While문
    {
        static void Main4(string[] args)
        {
            /*
            while (조건){
                조건이 참인동안 코드 실행
            }
            */

            // 1부터 10까지 합
            int i = 1;
            int sum = 0;

            while (i <= 10) 
            {
                sum += i;
                i++;
            }

            Console.WriteLine("sum : {0}", sum);

            // do - while
            // 최초 1번 반복을 수행하는 반복문
            // while문 조건 상관없이 먼저 반복문 실행
            // 그리고 반복문 조건 확인 만족하면 다시 실행 
            // 만족안하면 반복문 탈출
            

            // 1부터 10까지 짝수들의 합
            // 앞의 변수값을 초기화
            i = 1;
            sum = 0;

            do
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                i++;
            } while (i <= 10);

            Console.WriteLine("sum : {0}", sum);

            // break
            
            // 반복문에서 특정 조건을 만족하면 탈출하는데 자주 사용한다
            // for문, while문 둘 다 이용가능

            // 5와 7의 최소 공배수
            i = 1;
            
            while (true) 
            {
                if (i % 5 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("5와 7의 최소공배수 : {0}", i);
                    break;
                }
                i++;
            }

            // continue
            // 반복문에서 특정 조건을 만족하면 아래 코드 무시하고 다음 회차로 넘어가는데 사용한다
            // 1부터 10까지 짝수들의 합

            i = 1;
            sum = 0;

            
            while (i <= 10)
            {
                i++;
                if (i % 2 == 1)
                {
                    continue;
                }
                sum += i;

            }

            Console.WriteLine("1 부터 10 까지 짝수들의 합 : {0}", sum);

        }
    }
}
