using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 3-12
 * 
 * break 키워드를 사용하지 않는 switch 조건문
 */

namespace Book.Ch03
{
    internal class ex12
    {
        static void Main12(string[] args)
        {
            Console.Write("이번 달 입력 : ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                
                default:
                    Console.WriteLine("대체 어떤 행성에 살고 계신가요?");
                    break;
            }
        }
    }
}
