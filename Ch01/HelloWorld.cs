using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : C# 개발환경 설정, Hello World 출력 교재 p44
 */

// https://discord.gg/eSxeztBZ 디스코드 가입 후 링크 클릭

namespace Ch01
{
    internal class HelloWorld
    {
        // svm 입력 후 Tap 2번 누름
        // 메소드
        static void Main1(string[] args)
        {
            // 기본 출력
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello C#!");

            // 서식 출력
            Console.WriteLine("Hello");
            Console.WriteLine("Korea");

            // WriteLine : \n 포함
            // Write : \n 포함 안됨 이어붙임
            Console.Write("Hello");
            Console.Write("Korea");

            // \t : 일정 간격 띄움
            // \n : 줄바꾸기
            Console.Write("\nHello\t");
            Console.Write("Korea\n");

            // 포맷 출력
            Console.WriteLine("{0} {1}", "Hello", "Busan");

        }
    }
}
