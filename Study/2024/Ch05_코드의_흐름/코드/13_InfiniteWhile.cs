using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 29
이름 : 배성훈
내용 : while문을 이용한 무한 반복 코드
    교재 p 172 ~ 174

    while문 역시 무한 반복 코드를 만들 수 있다
    반복을 실행하기전 조건을 확인하기에 
    조건이 항상 참이면 무한히 반복 실행한다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _13_InfiniteWhile
    {

        static void Main13(string[] args)
        {

            int i = 0;
            while(true)
                Console.WriteLine(i++);
        }
    }
}
