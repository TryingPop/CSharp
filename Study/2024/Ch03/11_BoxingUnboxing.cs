using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 박싱 언박싱
    교재 p68 ~ 70

    메모리 측면에서 박싱, 언박싱에 관한 설명이 있다
    아래 코드인 
        int a = 123;
        object b = (object)a;
        int c = (int)b;
    부분을 메모리 관점에서 보자

    그러면 main 함수 안에서 실행되므로 스택에 a의 값이 담긴다
    b의 경우 참조형식이므로 힙에 a의 값을 어딘가에 저장하고 주소만 스택에 담긴다
    c의 경우 b가 가리키는 주소의 값을 확인해 c에 담고 c는 스택에 담긴다
*/

namespace Study._2024.Ch03
{
    internal class _11_BoxingUnboxing
    {

        static void Main11(string[] args)
        {

            int a = 123;
            object b = (object)a;   // a에 담긴 값을 박싱해서 힙에 저장
            int c = (int)b;         // b에 담긴 값을 언박싱해서 스택에 저장

            Console.WriteLine(a);   // 123
            Console.WriteLine(b);   // 123
            Console.WriteLine(c);   // 123

            double x = 3.1414213;
            object y = x;
            double z = (double)y;

            Console.WriteLine(x);   // 3.1414213
            Console.WriteLine(y);   // 3.1414213
            Console.WriteLine(z);   // 3.1414213
        }
    }
}
