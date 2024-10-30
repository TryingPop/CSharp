using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 선택적 인수
    교재 p 210 ~ 213

    메소드의 매개변수는 기본값을 가질 수 있다
    매개변수를 특정 값으로 초기화하듯 메소드를 선언할 수 있다

    필요한 경우에는 인수를 입력할 수도 있다
    기본값을 가진 매개변수는 필요에 따라 인수를 할당하거나 할당하지 않을 수 있기 때문에
    이를 선택적 인수(Optional Argument)라 부른다

    선택적 인수는 모호함이라는 스트레스도 같이 준다
    매개변수의 수가 많으면 명명된 인수의 도움을 받으면 쉽게 문제를 풀 수 있다
*/

namespace Study._2024.Ch06_메소드.코드
{
    internal class _10_OptionalParameter
    {

        static void PrintProfile(string name, string phone = "")
        {

            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main10(string[] args)
        {

            PrintProfile("중근");                                 // Name:중근, Phone:
            PrintProfile("관순", "010-123-1234");                 // Name:관순, Phone:010-123-1234
            PrintProfile(name: "봉길");                           // Name:봉길, Phone:
            PrintProfile(name: "동주", phone: "010-789-7890");    // Name:동주, Phone:010-789-7890
        }
    }
}
