using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 연습문제 5
    교재 p 113

    다음 코드를 컴파일한 후의 a와 b는 각각 어떤 데이터 형식이겠습니까?
    
    코드
        var a = 2020;
        var b = "double";

    a는 int(System.Int32) 자료구조가 될 것이다
    b는 string(System.String) 자료구조가 될 것이다

    보통 리터럴 정수형 데이터는 int 범위에 들어가면 정수형 자료구조는 int로 변환한다
    반면 리터럴 정수형 데이터는 int 범위를 벗어나고 long 범위에 들어가면 long 범위로 변환
    하지만 리터럴 정수형 데이터가 long 범위도 벗어나면 컴파일 에러를 일으킨다
*/

namespace Study._2024.Ch03
{
    internal class _34_ex_05
    {
    }
}
