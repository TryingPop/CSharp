using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 3-14
 * 
 * 키 입력 구분
 */

namespace Book.Ch03
{
    internal class ex16
    {
        static void Main16(string[] args)
        {
            Console.WriteLine("방향키 입력");
            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로 이동");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로 이동");
                    break ;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽으로 이동");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽으로 이동");
                    break;
                default:
                    Console.WriteLine("방향키를 눌러주세요");
                    break;

            }
        }
    }
}
