using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 3-11
 * 
 * switch 조건문
 */

namespace Book.Ch03
{
    internal class ex11
    {
        static void Main11(string[] args)
        {
            Console.Write("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());

            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수 입니다.");
                    break;
                
                case 1:
                    Console.WriteLine("홀수 입니다.");
                    break;
            }
        }
    }
}
