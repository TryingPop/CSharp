using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 10-5
 * 
 * finally 구문을 사용하지 않은 코드
 */

namespace Book.Ch10
{
    internal class ex05
    {
        static void Main5(string[] args)
        {
            Console.Write("입력 : ");
            string input = Console.ReadLine();

            try
            {
                int index = int.Parse(input);
                Console.WriteLine($"입력 숫자 : {index}");
            }
            catch (Exception exception)
            {
                Console.WriteLine("예외가 발생했습니다.");
                Console.WriteLine(exception.GetType());
                return;
            }

            Console.WriteLine("프로그램이 종료되었습니다.");
        }
    }
}
