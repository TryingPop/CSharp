using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 데이터 형식 변환 실습하기 교재 p106
 * 
 */

namespace Ch02
{
    internal class _5_변환
    {
        static void Main5(string[] args)
        {
            // 작은 변수에서 큰 변수로 데이터 이동
            byte num1 = 255;
            short num2 = num1;
            int num3 = num2;

            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num2 : {0}", num2);
            Console.WriteLine("num3 : {0}", num3);

            // 큰 변수에서 작은 변수로 데이터 이동
            int num4 = 256;
            // short로 강제 변환(Casting) 변환하지 않을시 오류가 뜬다
            short num5 = (short)num4;
            // 데이터 손실이 일어나서 값이 변환된다 오버플로우?
            byte num6 = (byte)num5;

            Console.WriteLine("num4 : {0}", num4);
            Console.WriteLine("num5 : {0}", num5);
            Console.WriteLine("num6 : {0}", num6);

            // 정수에서 실수
            // 크기는 문제 없다
            int a = 1;
            int b = 2;
            int c = 3;

            double d1 = a;
            double d2 = b;
            double d3 = c;

            // 표현만 정수로 되지만 메모리에는 실수로 보관 중임
            // 연습문제에서 확인하기!
            Console.WriteLine("d1 : " + d1);
            Console.WriteLine("d2 : " + d2);
            Console.WriteLine("d3 : " + d3);

            // 실수에서 정수
            double n1 = 1.2;
            double n2 = 2.14;
            double n3 = 12.123;

            // 소수부분만 사라진다
            int num7 = (int)n1;
            int num8 = (int)n2;
            int num9 = (int)n3;

            Console.WriteLine($"num7 : {num7}");
            Console.WriteLine($"num8 : {num8}");
            Console.WriteLine($"num9 : {num9}");

        }
    }
}
