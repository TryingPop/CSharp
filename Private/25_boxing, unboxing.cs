using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.08.22
 * 내용 : 박싱, 언박싱 : 값 타입과 참조 타입의 변환
 */

namespace Private
{
    internal class _25_boxing__unboxing
    {
        class A
        {

        }
        static void Main(string[] args)
        {
            // A a = null; // 메모리 생성되지 않음
            // A a = new A(); // 메모리 생성, 변수 a는 생성된 A의 주소만 갖게됨
            // A aa = a; // 새로운 메모리를 할당하지 않고 참조하는 값만 복사

            // 박싱(boxing)
            int i = 123;
            object o = i; // 박싱 값타입을 참조타입으로 변환
            Console.WriteLine(o); // 123
            // 스택에 있는 i가 힙에서 복사가 한 번 일어난다
            // 그리고 힙에 복사된 이 영역을 참조 타입이 가리키는 역할
            i += 1; // i == 124
            Console.WriteLine(o); // 123

            // 언박싱(unboxing)
            int j = 123;
            object o2 = j; 
            int k = (int)o2; // 언박싱 참조타입을 값타입으로 변환
            // 힙에 있는 데이터를 다시 스텍으로 복사
            // 인터페이스 타입이 필요한 부분에 값 타입의 객체를 적용하기 위해 필요한 기능이지만
            // 가능하면 안쓰는것이 좋다
            // is 연산자를 통해 캐스팅이 되는지 먼저 확인해야한다

        }
    }
}

// 참고 사이트
// https://afsdzvcx123.tistory.com/entry/C-%EB%AC%B8%EB%B2%95-%EB%B0%95%EC%8B%B1%EA%B3%BC-%EC%96%B8%EB%B0%95%EC%8B%B1%EC%9D%B4%EB%9E%80