using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 부동 소수점 형식과, 정수 형식 사이의 변환
    교재 p 75

    소수점 아래는 버리고 소수점 위의 값만 남긴다
*/

namespace Study._2024.Ch03
{
    internal class _15_FloatToIntegral
    {

        static void Main15(string[] args)
        {

            float a = 0.9f;
            int b = (int)a;
            Console.WriteLine(b);   // 0

            float c = 1.1f;
            int d = (int)c;
            Console.WriteLine(d);   // 1

            float e = 1e12f;
            int f = (int)e;
            Console.WriteLine(f);   // -2147483648
        }
    }
}
