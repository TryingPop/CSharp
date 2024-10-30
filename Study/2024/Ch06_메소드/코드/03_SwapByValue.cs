using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 매개변수에 대하여
    교재 p192 ~ 195

    매개변수는 메소드 외부로부터 메소드 내부로 데이터를 전달 받는 매개체 역할을 할 뿐이다.
    매개변수는 근복적으로 변수이기에 한 변수를 다른 변수에 할당하면 변수가 담고 있는 데이터만 복사될 뿐이다
    그 데이터가 값이던 참조던 간에 말이다

    메소드 안에서 매개변수를 수정한다고 해서,
    별개의 메모리 공간을 사용하기에 전달했던 변수에는 아무런 영향을 주지 않는다
*/

namespace Study._2024.Ch06_메소드.코드
{
    internal class _03_SwapByValue
    {

        public static void Swap(int a, int b)
        {

            int temp = b;
            b = a;
            a = temp;
        }

        static void Main3(string[] args)
        {

            int x = 3;
            int y = 4;

            Console.WriteLine($"x: {x}, y: {y}");       // x: 3 y: 4

            Swap(x, y);

            Console.WriteLine($"x: {x}, y: {y}");       // x: 3, y: 4
        }
    }
}
