using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 메소드
    교재 p185 ~ 190

    메소드(Method)는 객체지향 프로그래밍 언어에서 사용하는 용어로,
    C, C++ 언어에서는 함수(Function)라 불렀고 파스칼에서는 프로시저(Procedure)라 불렀다
    혹은 서브루틴(Subroutine)이나 서브 프로그램(Subprogram)이라 부르는 언어도 있다
    엄밀히는 의미 차이가 존재하지만, 큰 맥락에서는 이 용어들이 같은 것을 지칭한다고 할 수 있다

    메소드는 일련의 코드를 하나의 이름 아래 묶은 것이다
    메소드 이름을 불러주는 것만으로도 실행할 수 있다

    객체지향 프로그래밍에서는 코드 내의 모든 것을 객체로 표현한다
    각 객체는 자신만의 속성(데이터)과 기능(메소드)을 갖고 있는데,
    클래스가 바로 이 객체를 위한 청사진을 제공한다

    메소드의 형식은 다음과 같다

        한정자 반환_형식 메소드_이름 ( 매개변수_목록 )
        {

            // 실행하고자 하는 코드들
            ...
            
            return 메소드_결과;      // 메소드 결과의 데이터 형식은 메소드의 반환 형식과 일치해야 한다
        }

    메소드는 매개변수와 반환 형식을 갖고 있다
    매개 변수는 메소드에 집어넣는 재료이다
    반환형식은 나오는 결과이다

    매개변수는 호출자에게서 전달받은 값을 받는 변수를 말하고,
    인수는 호출자가 매개변수에 넘기는 값을 뜻한다

    void 반환형식이 있다
    자기 할 일만 하고 종료하는 메소드에 쓴다

    static 한정자
    static은 사전적으로는 정적이라는 뜻을 갖고 있다
    움직이지 않는다는 뜻이다
*/

namespace Study._2024.Ch06_메소드
{
    internal class _01_Calculator
    {

        public class Calculator
        {

            public static int Plus(int a, int b)
            {

                return a + b;
            }

            public static int Minus(int a, int b)
            {

                return a - b;
            }
        }

        static void Main1(string[] args)
        {

            int result = Calculator.Plus(3, 4);     // 7
            Console.WriteLine(result);

            result = Calculator.Minus(5, 2);        // 3
            Console.WriteLine(result);
        }
    }
}
