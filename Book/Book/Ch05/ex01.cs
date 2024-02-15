using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-1
 * 
 * Random 클래스를 사용한 임의의 정수 생성
 */

namespace Book.Ch05
{
    internal class ex01
    {
        static void Main1(string[] args)
        {
            Random random = new Random();

            // args : 1개이면 끝 숫자(0부터 시작, 끝 숫자는 미포함)
            Console.WriteLine(random.Next(1));
            // args : 시작 숫자, 끝 숫자(마찬가지로 미포함)
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
        }
    }
}
