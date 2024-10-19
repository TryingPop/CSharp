using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-8
 * 
 * 특정한 크기의 배열 생성
 */

namespace Book.Ch04
{
    internal class ex08
    {
        static void Main8(string[] args)
        {
            int[] intArray = new int[100];
            
            // 숫자는 초기값이 0, 문자열은 "", 다른 객체는 null 로 초기값이 잡혀있다
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[100]);
        }
    }
}
