using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 변수 실습하기 교재 p79
 * 
 * 변수(Variable)
 *  - 데이터를 처리하기 위한 데이터 그릇
 *  - 변수는 메모리상에 생성되는 공간
 *  
 *  
 * 상수(Constant)
 *  - 데이터를 변경할 수 없는 변수
 *  - 최초 저장(초기화)된 데이터를 고정
 *  
 */

namespace Ch02
{
    internal class _1_변수
    {
        // Ch2 이후로 런타임을 하기 위해선 Main?를 Main으로 변경해야한다.
        static void Main1(string[] args)
        {
            // 변수
            // 정수형 num1 선언
            int num1;   
            // num1에 숫자 1 할당
            num1 = 1;

            // 선언과 초기화 한번에 실행
            int num2 = 2;

            // 연산을 통해 변수 선언
            int num3 = num1 + num2; 

            // 결과 확인
            // + 연산자를 통해 num3 값 뒤에 출력 가능
            Console.WriteLine("num3 : "+num3);


            // const(상수) : 한번 저장된 데이터를 변경할 수 없는 데이터라 변수랑 다르다
            // num에 10값 선언
            int num = 10;
            // num에 20값 덮어쓴다
            num = 20;

            // 상수 NUM에 10값 선언, 상수는 대문자로 선언한다.
            const int NUM = 10;
            // NUM = 20; // 상수이므로 주석 해제하면 오류가 뜬다 
            // 상수는 값 변경 불가능

            // 상수 PI에 실수값 3.14 선언
            const double PI = 3.14;

            // 결과 확인
            Console.WriteLine("NUM : " + NUM);
            Console.WriteLine("PI : " + PI);

        }
    }
}


/* 하드디스크(HDD)에 파일 저장
 * RAM에 변수들 저장
 * CPU에서 연산
 * 그리고 새로 생성된 메모리 RAM에 저장
 * 새로 생성된 메모리를 영구보관한다면 파일로 만들어 HDD에 보관하기
 */