using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 문자열 서식 맞추기 (문자열 보간)
    교재 p109 ~ 111

    앞에서 사용하던 string.Format()이 아닌
    문자열 앞에 $ 키워드를 붙여 사용하는 방법이다
*/

using static System.Console;

namespace Study._2024.Ch03
{
    internal class _29_StringInterpolation
    {

        static void Main29(string[] args)
        {

            string name = "김튼튼";
            int age = 23;
            // 김튼튼       , 023
            WriteLine($"{name,-10}, {age:D3}");

            name = "박날씬";
            age = 30;
            // 박날씬, 030
            WriteLine($"{name}, {age, -10:D3}");

            name = "이비실";
            age = 17;
            // 이비실, 미성년자
            WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");
        }
    }
}
