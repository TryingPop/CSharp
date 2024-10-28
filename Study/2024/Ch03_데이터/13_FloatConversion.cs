using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 크기가 서로 다른 부동 소수점 형식 사이의 변환
    교재 p72 ~ 74

    부동 소수점 형식의 특성상 오버플로가 존재하지 않기에 그런 일은 없다
    다만 정밀성에 손상을 입는다

    float이나 double은 2진수로 메모리에 보관한다
*/

namespace Study._2024.Ch03
{
    internal class _13_FloatConversion
    {

        static void Main13(string[] args)
        {

            float a = 69.6875f;
            Console.WriteLine("a : {0}", a);                        // a : 69.6875

            double b = (double)a;
            Console.WriteLine("b : {0}", b);                        // b : 69.6875
            Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);  // 69.6875 == b : True

            float x = 0.1f;
            Console.WriteLine("x : {0}", x);                        // x : 0.1

            double y = (double)x;
            Console.WriteLine("y : {0}", y);                        // y : 0.10000000149011612

            Console.WriteLine("0.1 == y : {0}", 0.1 == y);          // 0.1 == y : False
        }
    }
}
