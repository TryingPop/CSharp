using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : 연습문제 1
    교재 p144

    i++와 ++i의 차이점은 무엇인가요?

    i가 정수형 데이터일 때,
    둘다 1을 증가시킨다는 점에서 같다
    그런데 증가 연산의 실행 시작에 차이가 있다

    두 연산에 다른 연산이 추가된 경우 확인할 수 있다
    해당 결과를 만약 출력한다고 하면
    System.Console.WriteLine(i++);

        System.Console.WriteLine(i);
        i += 1;
    의 결과와 같고

    System.Console.WriteLine(++i);
    
        i += 1;
        System.Console.WriteLine(i);
    의 결과와 같다

    연산의 정의로 들어가면 후위 연산자는 값이 증가했으나,
    증가 값 이전의 값을 반환해
        i += 1;
        System.Console.WriteLine(i);
    이와 같은 결과를 보인다
*/

namespace Study._2024.Ch04
{
    internal class _12_ex_01
    {
    }
}
