using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-17
 * 
 * foreach 반복문과 배열
 */

namespace Book.Ch04
{
    internal class ex17
    {
        static void Main17(string[] args)
        {   
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            // 다차원 배열도 하나씩 꺼내는게 가능하다
            // 다차원의 경우 순서대로 하나씩 나온다 
            // 인덱스가 0, 0 다음 0, 1 순서로
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
