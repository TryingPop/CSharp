using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 문자열 서식 맞추기 (Format - 숫자 서식화)
    교재 p 103 ~ 105

    {첨자, 맞춤:서식 문자열}
    서식 문자열
    D : 10진수
    X : 16진수
    N : (,)로 묶어 표현한 수
    F : 고정 소수점
    E : 지수
*/

using static System.Console;

namespace Study._2024.Ch03
{
    internal class _27_StringFormatNumber
    {

        static void Main27(string[] args)
        {

            // D: 10진수
            // 123
            WriteLine("10진수: {0:D}", 123);
            // 00123
            WriteLine("10진수: {0:D5}", 123);


            // X: 16진수
            // 0xFF1234
            WriteLine("16진수: 0x{0:X}", 0xFF1234);
            // 0x00FF1234
            WriteLine("16진수: 0x{0:X8}", 0xFF1234);

            // N: 숫자
            // 123,456,789.00
            WriteLine("숫자: {0:N}", 123456789);
            // 123,456,789
            WriteLine("숫자: {0:N0}", 123456789); // 소수점 이하를 제거

            // F: 고정 소수점
            // 123.45
            WriteLine("고정 소수점: {0:F}", 123.45);
            // 123.45600
            WriteLine("고정 소수점: {0:F5}", 123.456);

            // E: 공학용
            // 1.234568E+002
            WriteLine("공학: {0:E}", 123.456789);
        }
    }
}
