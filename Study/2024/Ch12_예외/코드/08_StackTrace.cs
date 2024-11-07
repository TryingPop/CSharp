using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 7
이름 : 배성훈
내용 : 예외 처리 다시 생각해보기
    교재 p 451 ~ 453

    try ~ catch 문을 이용한 예외 처리는 
    실제 일을 하는 코드 문제를 처리하는 코드를 깔끔하게 분리시킨다.
    코드를 간결하게 만들어준다.

    StackTrace 프로퍼티를 통해 문제가 발생한 부분의 소스코드의 위치를 알려주기에 디버깅이 아주 용이하다.
*/

namespace Study._2024.Ch12_예외.코드
{
    internal class _08_StackTrace
    {

        static void Main8(string[] args)
        {

            try
            {

                int a = 1;
                Console.WriteLine(3 / -- a);
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
