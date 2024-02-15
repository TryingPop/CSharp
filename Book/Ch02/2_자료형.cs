using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 자료형 실습하기 교재 p63
 * 
 * 자료형(Data Type)
 *  - 변수에 저장되는 데이터의 종류와 크기를 자료형으로 선언
 *  - 자료형은 크게 기본형과 참조형으로 나뉨(기본형만 확인)
 * 
 */


namespace Ch02
{
    internal class _2_자료형
    {
        static void Main2(string[] args)
        {
            // 정수형
            // sbyte 범위 : -128 ~ 127
            sbyte num1 = 127;

            // num1에 128 저장
            // num1 = 128; // 범위 오류로 출력 불가능하다

            // short 범위 : -32,768 ~ 32,767
            short num2 = 128;

            // 마찬가지로 num2에 32768 은 사용 불가능하다

            // int 범위 : -2,147,483,648 ~ 2,147,483,647
            // 용량이 커져서 int를 자주 이용한다.
            int num3 = 2147483647;

            // long 범위 : 92,233,720,368,477,507
            // L타입임을 알려주기 위해 마지막에 L을 붙인다.
            long num4 = 92233720368477507L;


            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num2 : {0}", num2);
            Console.WriteLine("num3 : {0}", num3);
            Console.WriteLine("num4 : {0}", num4);

            // 실수형
            // float은 접미사로 f를 적어줘야한다.
            float var1 = 0.123456789f;
            double var2 = 0.1234567890123456789;

            // float은 8자리, double은 17자리 넘은 자리는 반올림
            Console.WriteLine("var1 : {0}", var1);
            Console.WriteLine("var2 : {0}", var2);

            // 논리형
            bool b1 = true;
            bool b2 = false;

            Console.WriteLine("b1 : " + b1);
            Console.WriteLine("b2 : " + b2);


            // 문자형
            // char는 '' 이용
            // 넘버링으로도 표현 불가능 c++ std와 구분하기
            char c1 = 'A';
            char c2 = '가';

            Console.WriteLine("c1 : " + c1);
            Console.WriteLine("c2 : " + c2);


            // 문자열
            // 힙메모리 옵션에 따라 문자열 길이 제한이 존재한다. 메모리가 알아서 증식
            string str1 = "A";
            string str2 = "가";
            string str3 = "Apple";
            string str4 = "안녕하세요.";
            // 문자열 10을 숫자 10이랑 타입 혼동 주의하기
            string str5 = "10";

            Console.WriteLine("str1 : {0}", str1);
            Console.WriteLine("str2 : {0}", str2);
            Console.WriteLine("str3 : {0}", str3);
            Console.WriteLine("str4 : {0}", str4);
            Console.WriteLine("str5 : {0}", str5);

            // object형
            // 타입 구분 없이 쓸 수 있지만 자주 안쓰는 표현이다
            // heap 영역에 저장되는 메모리라 크기가 많이 중요하지는 않다
            object obj1 = 10;
            object obj2 = 3.14;
            object obj3 = true;
            object obj4 = 'A';
            object obj5 = "Apple";

            Console.WriteLine("obj1 : {0}", obj1);
            Console.WriteLine("obj2 : {0}", obj2);
            Console.WriteLine("obj3 : {0}", obj3);
            Console.WriteLine("obj4 : {0}", obj4);
            Console.WriteLine("obj5 : {0}", obj5);

            // var형
            // 최신 C# 문법 동적
            // 실행할 때 알아서 변수 형태를 구분한다
            // 메모리 공간역시 변수 형태에 맞게 찾는다
            var v1 = 10;
            var v2 = 3.14;
            var v3 = true;
            var v4 = 'A';
            var v5 = "Apple";

            Console.WriteLine("v1 : {0}", v1);
            Console.WriteLine("v2 : {0}", v2);
            Console.WriteLine("v3 : {0}", v3);
            Console.WriteLine("v4 : {0}", v4);
            Console.WriteLine("v5 : {0}", v5);

        }
    }
}
/* sbyte처럼 음수를 저장할 때 
 * 메모리에 값을 저장할 때 맨 앞에는 부호를 나타낸다
 */