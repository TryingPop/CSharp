using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 반복문 for 실습하기 교재 p157
 * 
 */

namespace Ch03
{
    internal class _3_For문
    {
        static void Main3(string[] args)
        {
            /* for 문
        for(args : 초기식; 조건식; 증감식)
        {
            실행 코드
        }
        */
            // for
            // 전위 증감, 후위 증감 차이가 없다
            // i가 기준, 조건식 만족하면 코드 실행 >> 이후에 i증감
            // i++ 대신에 i+=1 로 해도 된다
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("{0} 회 반복 ... ", i);
            }


            // 1 부터 10 까지 합
            int sum = 0;

            for (int j = 1; j <=10; j++)
            {
                sum += j;
            }

            Console.WriteLine($"1 부터 10 까지의 합 : {sum}");


            // 1 부터 10 까지 짝수합
            int tot = 0;
            for (int k = 1; k <= 10; k++)
            {
                if (k % 2 == 0)
                {
                    tot += k; 
                }
            }

            Console.WriteLine($"1 부터 10 까지 짝수들의 합 : {tot}");

            // 중첩 for 문
            for (int a = 1; a <= 3; a++)
            {
                Console.WriteLine("a : {0}", a);

                for (int b=1; b < 5; b++)
                {
                    Console.WriteLine("b : {0}", b);
                }
            }


            // 구구단
            int z;
            for (int x = 2; x <= 9; x++)
            {
                Console.WriteLine();
                Console.WriteLine($"===={x}단====");
                for (int y = 1; y <= 9; y++)
                {
                    z = x * y;
                    if (z >= 10)
                    {
                        Console.WriteLine("{0} X {1} = {2}", x, y, z);
                    }
                    else
                    {
                        Console.WriteLine("{0} X {1} = 0{2}", x, y, z);
                    }
                    
                }
                Console.WriteLine("===========");
                Console.WriteLine();
            }

            // 별 삼각형
            for (int height = 1; height <= 10; height++)
            {
                for (int width = 1; width <= height; width++)
                {
                    Console.Write("◆");
                }
                Console.WriteLine("");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int height = 1; height <= 10; height++)
            {
                for (int width = 10; width >= height; width--)
                {
                    Console.Write("◆");
                }
                Console.WriteLine();
            }

            
        }
    }
}

/* vs에서 디버깅 하는 법
 먼저 왼쪽 C# 세로 라인에 클릭
 그러면 누른 코드 앞에서 멈춘다
 F11누르면 하나씩 단계 진행
 조사식에서 원하는 변수 입력해서
 주피터처럼 변화 상태 확인하기!
 */