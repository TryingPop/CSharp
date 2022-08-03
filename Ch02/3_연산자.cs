using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 연산자 실습하기 교재 p90
 * 
 * 연산자(Operator)
 *  - 변수에 저장된 데이터를 가공하기 위해 연산자를 사용
 *  - 연산자는 크게 산술, 증감, 복합대입, 비교, 논리 연산자 등이 있다.
 *  
 */

namespace Ch02
{
    internal class _3_연산자
    {
        static void Main3(string[] args)
        {
            // 산술 연산자
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;

            // 사칙 연산과 나머지
            int r1 = num1 + num2;
            int r2 = num1 - num2;
            int r3 = num2 * num3;
            int r4 = num3 / num4;
            // 나머지
            int r5 = num4 % num3; 

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);
            Console.WriteLine("r4 : " + r4);
            Console.WriteLine("r5 : " + r5);

            // 증감 연산자
            int num = 0;

            // 코드 실행 후 1증가
            num++;
            
            Console.WriteLine("num : {0}", num);

            // 1증가 후 코드 실행
            ++num;
            
            // 문자열 보간 python f-string
            Console.WriteLine($"num : {num}");

            // 마찬가지로 -도 가능하다
            // 1감소 후 뒤쪽 코드 실행
            --num;

            Console.WriteLine($"num : {num}");

            // 복합대입 연산자
            int n1 = 1, n2 = 2, n3 = 3, n4 = 4;

            // 1만큼 더하라
            n1 += 1;
            // 2만큼 빼라
            n2 -= 2;
            // 3만큼 곱하라
            n3 *= 3;
            // 5만큼 나눠라
            n4 /= 5;

            Console.WriteLine($"n1 : {n1}");
            Console.WriteLine($"n2 : {n2}");
            Console.WriteLine($"n3 : {n3}");
            // n4가 int라 소숫점은 날아가버림            
            // 0으로 출력된다
            Console.WriteLine($"n4 : {n4}");

            // 비교 연산자
            int var1 = 1;
            int var2 = 2;

            // 앞에 r1을 int로 해서 rs1 말고 r1으로 하면
            // 디버그가 발생한다
            bool rs1 = var1 > var2;
            bool rs2 = var1 < var2;
            bool rs3 = var1 >= var2;
            bool rs4 = var1 <= var2;
            // 둘이 같다
            bool rs5 = var1 == var2;
            // 둘이 다르다
            bool rs6 = var1 != var2;

            Console.WriteLine($"var1 > var2 : {var1 > var2}");
            Console.WriteLine("rs1 : {0}", rs1);
            Console.WriteLine("rs2 : {0}", rs2);
            Console.WriteLine("rs3 : {0}", rs3);
            Console.WriteLine("rs4 : {0}", rs4);
            Console.WriteLine("rs5 : {0}", rs5);
            Console.WriteLine("rs6 : {0}", rs6);

            // 논리 연산자
            // && : and, || : or, ! : not
            bool res1 = var1 > 1 && var2 > 2; 
            bool res2 = var1 < 2 || var2 > 1;
            bool res3 = !(var1 > var2);

            Console.WriteLine("res1 : {0}", res1);
            Console.WriteLine("res2 : {0}", res2);
            Console.WriteLine("res3 : {0}", res3);

            // 조건 연산자
            int number = 1;
            
            // (조건) ? 참일시 실행 코드:거짓일시 실행 코드
            string result1 = (number > 0) ? "True" : "False";
            string result2 = (number > 1) ? "True" : "False";
            
            Console.WriteLine("result1 : {0}", result1);
            Console.WriteLine("result2 : {0}", result2);
        }
    }
}

// 증감 연산자 주의할 점

// Console.WriteLine(num++);
// 와
// Console.WriteLine(num);
// num += 1;
// 같다.

// 반면
// ++num;
// 와
// num += 1;
// Console.WriteLine(num);
// 같다

// 대입 연산자에서 주의하기!
// Console.WriteLine(num)을 result = num으로 바꿔서도 생각해보기!