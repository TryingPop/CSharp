using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 문자열 서식 맞추기(Format - 왼쪽 오른쪽 맞추기)
    교재 p 99 ~ 102

    문자열을 예쁘게? 혹은 원하는 형식으로 출력하기 위한 방법이다
    Format을 이용한 방법과 보간을 이용한 방법이 있다

    {첨자, 맞춤}
    형태로 사용한다
    맞춤이 양수면 오른쪽 끝에 붙여 출력
    음수면 왼쪽 끝에 붙여 출력한다
*/

using static System.Console;

namespace Study._2024.Ch03
{
    internal class _26_StringFormatBasic
    {

        static void Main26(string[] args)
        {

            // 20칸 할당하고 왼쪽에 붙여쓴다
            // 15칸 할당하고 왼쪽에 붙여쓰기
            // 30칸 할당하고 오른쪽 붙여쓰기
            string fmt = "{0,-20}{1,-15}{2,30}";

            // Publisher           Author                                  Title
            // Marvel              Stan Lee                             Iron Man
            // Hanbit              Sanghyun Park                      This is C#
            // Prentice Hall       K&R                The C Programming Language
            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "This is C#");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
        }
    }
}
