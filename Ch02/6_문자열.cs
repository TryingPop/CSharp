using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 문자열 실습하기 교재 p112
 * 
 */

namespace Ch02
{
    internal class _6_문자열
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            Console.WriteLine(greeting);
            Console.WriteLine();

            // 문자열 길이
            Console.WriteLine("길이 : "+ greeting.Length);
            Console.WriteLine();

            // 문자열 추출
            // 연습문제 확인
            Console.WriteLine();
            Console.WriteLine("greeting 1번째 문자 : " + greeting[0]);
            Console.WriteLine("greeting 6번째 문자 : " + greeting[5]);
            // 길이보다 크거나 음수면 예외처리
            // Console.WriteLine("greeting 100번째 문자 : " + greeting[100]);
            // Console.WriteLine("greeting 1번째 문자 : " + greeting[-1]);
            Console.WriteLine();

            // 문자열 index
            Console.WriteLine();
            Console.WriteLine("'G' 인덱스 : " + greeting.IndexOf('G'));
            Console.WriteLine("'M' 인덱스 : " + greeting.IndexOf('M'));
            // 중복되면 앞의 번호만 입력한다
            Console.WriteLine("'o' 인덱스 : " + greeting.IndexOf('o'));
            Console.WriteLine("'o' 의 마지막 인덱스 : " + greeting.LastIndexOf('o'));

            // 존재하지 않는 인덱스의 경우 -1로 출력한다
            Console.WriteLine("'k' 의 인덱스 : " + greeting.IndexOf('k'));

            // 문자열 자르기
            // args : 시작값, 길이
            // 인덱스 0에서 4개의 문자열 == 인덱스가 0~3까지 문자열
            Console.WriteLine();
            Console.WriteLine("greeting 인덱스가 0~3 까지 문자열 : " + greeting.Substring(0, 4));
            Console.WriteLine("greeting 인덱스가 5~7 까지 문자열 : " + greeting.Substring(5, 3));
            Console.WriteLine("greeting 인덱스가 5~마지막까지 문자열 : " + greeting.Substring(5));

            // 문자열 교체
            // args : old string, new string
            // 기존 변수는 수정이 안된다
            string replaced = greeting.Replace("Morning", "Afternoon");

            Console.WriteLine();
            Console.WriteLine("greeting : {0}", greeting);
            Console.WriteLine("replaced : {0}", replaced);

            // 문자열 변환
            // 문자열은 class형태 연습문제 참조
            // 기본 형태를 문자열로
            // 여기서 기본형태는 수, 불
            int var1 = 1;
            double var2 = 2.12345;
            bool var3 = true;

            // 문자열로 변환되어서 사칙연산 불가능
            string str1 = var1.ToString();
            string str2 = var2.ToString();
            // true의 머리는 대문자 
            string str3 = var3.ToString();
            // 직관적
            string str4 = "" + var3;

            Console.WriteLine();
            Console.WriteLine("str1 : " + str1);
            Console.WriteLine("str2 : " + str2);
            
            Console.WriteLine("str3 : " + str3);
            Console.WriteLine("str4 : " + str3);

            // 문자열을 기본 형태로
            string s1 = "100";
            string s2 = "3.14";
            string s3 = "false";

            int r1 = int.Parse(s1);
            double r2 = double.Parse(s2);
            bool r3 = bool.Parse(s3);

            Console.WriteLine();
            Console.WriteLine("r1 : {0}", r1);
            Console.WriteLine("type : {0}", r1.GetType());
            Console.WriteLine("r2 : {0}", r2);
            Console.WriteLine("type : {0}", r2.GetType());
            Console.WriteLine("r3 : {0}", r3);
            Console.WriteLine("type : {0}", r3.GetType());
        }
    }
}
