using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private
{
    internal class _23_재귀함수
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DangerFactorial(5));
            Console.WriteLine(Factorial(5));
        }

        public static int DangerFactorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * DangerFactorial(n - 1);
            }
        }

        // 꼬리 재귀
        // 호출이 끝나는 시점에서 아무 일도 하지 않고 바로 결과를 반환하도록 하는 방법으로 함수의 상태 유지 및 추가 연산을 하지 않기에 스택 오버플로우를 해결할 수 있다.
        // 다만 컴파일러가 꼬리 재귀를 지원해야만 실질적으로 단점을 보완
        // 닷넷은 지원 X
        public static int Factorial(int n, int total = 1)
        {
            if (n <= 1)
            {
                return total;
            }
            else
            {
                return Factorial(n - 1, total * n);
            }
        }
    }
}

// 참고 사이트
// https://catsbi.oopy.io/dbcc8c79-4600-4655-b2e2-b76eb7309e60
// https://bentist.tistory.com/57
// https://tecoble.techcourse.co.kr/post/2020-04-30-iteration_vs_recursion/

// 재귀함수를 이용하면 for문보다 가독성이 좋아진다 또한 사용하는 변수의 양이 줄어든다.
// 닷넷과 관련된 꼬리재귀 글
// http://daplus.net/c-net-c-%EC%9D%B4-%EA%BC%AC%EB%A6%AC-%ED%98%B8%EC%B6%9C-%EC%9E%AC%EA%B7%80%EB%A5%BC-%EC%B5%9C%EC%A0%81%ED%99%94%ED%95%98%EC%A7%80-%EC%95%8A%EB%8A%94-%EC%9D%B4%EC%9C%A0%EB%8A%94-%EB%AC%B4/