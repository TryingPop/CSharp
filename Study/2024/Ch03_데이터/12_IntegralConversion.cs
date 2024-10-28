using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 데이터 형식 바꾸기 (크기가 서로 다른 정수 형식 사이의 변환)
    교재 p 70 ~ 72

    변수를 다른 데이터 형식의 변수에 옮겨 담는 것을 형식 변환이라 한다
    앞에서 확인한 박싱 언박싱도 값 형식과 참조 형식 간의 형식 변환이라고 할 수 있다

    살펴볼 형식 변환은 다음과 같은 5가지 이다
        크기가 서로 다른 정수 형식 사이의 변환
        크기가 서로 다른 부동 소수점 형식 사이의 변환
        부호 있는 정수 형식과 부호 없는 정수 형식 사이의 변환
        부동 소수점 형식과 정수 형식 사이의 변환
        문자열과 숫자 사이의 변환
    
    작은 정수 형식을 큰 정수 형식으로 변환할 때는 이상없지만
    큰 정수 형식에서 작은 데이터 정수 형식으로 변환할 때는 데이터 손실이 있을 수 있다
*/

namespace Study._2024.Ch03
{
    internal class _12_IntegralConversion
    {

        static void Main12(string[] args)
        {

            sbyte a = 127;
            Console.WriteLine(a);   // 127

            int b = (int)a;
            Console.WriteLine(b);   // 127

            int x = 128;            // sbyte의 최대값 127보다 1 큰수
            Console.WriteLine(x);   // 128

            sbyte y = (sbyte)x;     // 오버플로 발생
            Console.WriteLine(y);   // -1
        }
    }
}
