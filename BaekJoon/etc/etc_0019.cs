using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 2. 11
이름 : 배성훈
내용 : 부분 문자열
    문제번호 : 16916번

    KMP 알고리즘 연습문제!
    이전에 작성해본 코드지만, 바로 안작성된다
    저녁에 다시 해봐야겠다

    일단 KMP 규칙을 확인하자!
*/

namespace BaekJoon.etc
{
    internal class etc_0019
    {

        static void Main19(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            string str = sr.ReadLine();

            string chk = sr.ReadLine();

            sr.Close();

            // 돌아갈 구간
            int[] back = new int[chk.Length];

        }
    }
}
