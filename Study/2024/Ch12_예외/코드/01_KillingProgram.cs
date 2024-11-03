using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 3
이름 : 배성훈
내용 : 예외
    교재 p 433 ~ 

    프로그래머가 시나리오에서 벗어나는 사건을 예외(Exception)이라고 부른다.
    예외가 프로그램의 오류나 다운으로 이어지지 않도록 적절하게 처리하는 것을 예외 처리(Exception Handling)라고 한다.

    아래 예제를 보면 배열의 잘못된 인덱스 접근으로 배열 객체는 상세 정보는 IndexOutOfRangeException의 객체에 담은 후 Main 메소드에 던진다.
    Main은 처리할 방법이 없기에 CLR로 옮겨지고 CLR까지 전달된 예외는 예외 객체에 담긴 내용을 사용자에게 출력한 후 프로그램을 강제 종료한다.

    예외를 처리하지 못해 죽는 프로그램은 아무리 기능이 많아도 신뢰할 수 없다.
    프로그래머는 자신이 작성한 코드 내에서 예외가 처리되도록 조치를 취해야 한다.
*/

namespace Study._2024.Ch12_예외.코드
{
    internal class _01_KillingProgram
    {

        static void Main1(string[] args)
        {

            int[] arr = { 1, 2, 3 };

            // 1 2 3
            // IndexOutOfRangeException 발생
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("종료");
        }
    }
}
