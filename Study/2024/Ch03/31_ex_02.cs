using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 연습문제 2
    교재 p 112
    
    다음 코드에서 잘못된 부분을 찾고, 그 이유를 설명하세요

    코드    
        int a = 7.3;
        float b = 3.14;
        double c = a * b;
        char d = "abc";
        string e = '한';

    풀이
        a 는 정수 자료형인데 실수 자료형인 7.3이 들어와 컴파일 에러를 일으킨다
        b 는 float 형이지만 3.14는 double 형이므로 더 큰 자료형이므로 컴파일 에러를 일으킨다
        c 는 a, b가 잘 정의되었다면 컴파일에러를 발생하지 않는다
        d 는 char 자료형이지만 오른쪽은 문자열 자료형이므로 잘못된 자료형 입력으로 컴파일 에러를 일으킨다
        e 는 string 자료형이지만 '한'은 char형 자료형이므로 잘못된 자료형 입력으로 컴파일 에러를 일으킨다
*/

namespace Study._2024.Ch03
{
    internal class _31_ex_02
    {
    }
}
