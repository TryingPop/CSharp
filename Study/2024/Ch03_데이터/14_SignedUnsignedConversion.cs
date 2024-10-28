using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 부호 있는 정수 형식과 부호 없는 정수 형식 사이의 변환
    교재 p 74

    정수부분과 다를바 없다
*/

namespace Study._2024.Ch03
{
    internal class _14_SignedUnsignedConversion
    {

        static void Main14(string[] args)
        {

            int a = 500;
            Console.WriteLine(a);       // 500

            uint b = (uint)a;
            Console.WriteLine(b);       // 500

            int x = -30;
            Console.WriteLine(x);       // -30

            uint y = (uint)x;           // 언더 플로우
            Console.WriteLine(y);       // 4294967266
        }
    }
}
