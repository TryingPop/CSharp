using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 7
이름 : 배성훈
내용 : 연습문제 1
    교재 p 454
    
    다음 코드를 컴파일하면 실행 결과처럼 예외를 표시하고 비정상 종료합니다.
    try ~ catch 문을 이용해서 예외를 안전하게 처리하도록 코드를 수정하세요.

    코드
        using System;

        static void Main()
        {

            int[] arr = new int[10];
            
            for (int i = 0; i < 10; i++)
                arr[i] = i;

            for (int i = 0; i < 11; i++)
                Console.WriteLine(arr[i]);
        }


    실행결과
        0
        1
        2
        3
        4
        5
        6
        7
        8
        9
        처리 되지 않은 예외: System.IndexOutOfRangeException: ...
*/

namespace Study._2024.Ch12_예외.코드
{
    internal class _09_ex_01
    {

        static void Main9(string[] args)
        {

            int[] arr = new int[10];
            try
            {

                for (int i = 0; i < 10; i++)
                    arr[i] = i;

                for (int i = 0; i < 11; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
