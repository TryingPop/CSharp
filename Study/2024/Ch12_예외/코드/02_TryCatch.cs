using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 3
이름 : 배성훈
내용 : try ~ catch로 예외 받기
    교재 p434 ~ 436

    C#에서 예외를 받을 때 try catch 문을 이용한다.
    try 절의 코드 블록에는 예외가 일어나지 않을 경우에 실행되어야 할 코드들이 들어가고,
    catch 절에는 예외가 발생했을 때 처리 코드가 들어간다.

    try는 시도하다라는 뜻이고, catch는 잡다 또는 받다라는 뜻이다.
    catch 절은 try 블록에서 던질 예외 객체와 형식이 일치해야 받을 수 있다.
    다른 경우 예외를 받아낼 수 없다.
    예외는 Exception 클래스를 상속받으므로 Exception으로 모든 예외를 받을 순 있다.

    그리고 catch 블록은 else if 문처럼 여러 개를 둘 수 있다.
*/

namespace Study._2024.Ch12_예외.코드
{
    internal class _02_TryCatch
    {

        static void Main2(string[] args)
        {

            int[] arr = { 1, 2, 3 };

            // 1 2 3
            // 예외가 발생했습니다. : 인덱스가 배열 범위를 벗어났습니다.
            try
            {

                for (int i = 0; i < 5; i++)
                {

                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine($"예외가 발생했습니다.: {e.Message}");
            }

            Console.WriteLine("종료");
        }
    }
}
