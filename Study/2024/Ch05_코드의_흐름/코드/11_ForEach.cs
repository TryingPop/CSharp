using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 29
이름 : 배성훈
내용 : foreach 문
    교재 p 170 ~ 

    foreach문을 이해하기 위해서는 컬렉션의 개념을 이해해야 한다
    이는 10장에서 설명한다

    변수는 하나의 데이터만 담을 수 있다
    배열은 여러 개의 데이터를 담을 수 있는 코드 요소이며 변수 여러 개를 이어 붙인 것과 같다
    컬렉션도 여러 개의 데이터를 담는 코드 요소라는 점에서 배열과 비슷하지만
    사용하는 방식과 데이터를 저장하고 이에 접근하는 알고리즘이 다르다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _11_ForEach
    {

        static void Main11(string[] args)
        {

            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach(int a in arr)
            {

                Console.WriteLine(a);
            }
        }
    }
}
