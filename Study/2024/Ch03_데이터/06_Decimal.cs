using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : Decimal
    교재 p 59 ~ 60

    decimal 자료구조에 관한 설명이 있다
    float이나 double과 비교해서 얼마나 정밀한지 확인하 수 있다

    decimal의 크기는 16바이트이고, +- 10e-28 ~ 7.9 x 10e28 까지 표현가능하고
    29자리 데이터를 표현할 수 있는 소수 형식이다
*/

namespace Study._2024.Ch03
{
    internal class _06_Decimal
    {

        static void Main6(string[] args)
        {

            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f;
            double b = 3.1415_9265_3589_7932_3846_2643_3832_79;
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;

            Console.WriteLine(a);       // 3.1415927
            Console.WriteLine(b);       // 3.141592653589793
            Console.WriteLine(c);       // 3.1415926535897932384626433833
        }
    }
}
