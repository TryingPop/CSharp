using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 17
이름 : 배성훈
내용 : HelloWorld
    교재 p 19 ~ 34

    CLR(Common Language Runtime) 에서 실행된다고 한다
    CLR은 기타 언어들을 동작시키는 환경 기능 외에도, 
    프로그램의 오류가 발생했을 때 처리하도록 도와주는 기능, 언어간의 상속 지원, COM 과의 상호 운영성 지원, 그리고 자동 메모리 관리 등의 기능을 제공한다
*/

// System.Console 부분을 생략
using static System.Console;

// 이름 공간
namespace Book._2024.Ch02
{
    internal class _01_HelloWorld
    {

        // 프로그램 실행이 시작되는 곳
        static void Main1(string[] args)
        {
                
            if (args.Length == 0)
            {

                Console.WriteLine("사용법 : Hello.exe <이름>");
                return;
            }

            WriteLine("Hello, {0}", args[0]);
        }
    }
}
