using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 연습문제 2
    교재 p 216 ~ 217

    다음 코드에서 Mean() 메소드를 실행한 후의 mean은 얼마의 값을 가질까요?
    3이라고요? 아닙니다. 0입니다. 자, 문제 나갑니다. mean이 0을 갖게되는 원인은 무엇이며,
    이를 바로잡으려면 다음 코드에서 어떤 부분을 고쳐야 할까요?


    코드
        using System;

        public static void Main()
        {

            double mean = 0;

            Mean( 1, 2, 3, 4, 5, mean );

            Console.WriteLine("평균 : {0}", mean);
        }

        public static void Mean(
            double a, double b, double c,
            double d, double e, double mean)
        {

            mean = (a + b + c + d + e) / 5;
        }


    매개변수를 호출할 때 값에 의한 호출(Call by Value)이 이뤄졌기 때문에
    Mean함수의 매개변수 mean은 새롭게 복사된 값을 담은 것일 뿐이다
    함수 외부의 mean과 Mean 함수의 mean은 별개의 변수다

    해결하려면 참조에 의한 호출(Call by Reference)를 해야한다
    Mean 함수를 호출할 때 mean 매개변수 앞에 ref 키워드를 넣어 호출하고 
    선언도 ref double mean을 하면 된다
*/

namespace Study._2024.Ch06_메소드.코드
{
    internal class _13_ex_02
    {
    }
}
