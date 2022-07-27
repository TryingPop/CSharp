using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 10-6
 * 
 * finally 구문 사용
 */

namespace Book.Ch10
{
    internal class ex06
    {
        static void Main6(string[] args)
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
                // catch에서 return의 경우 finally 구문 건너뛴다.
                return;
                // continue, break은 사용하지 못한다.
            }
            finally
            {
                Console.WriteLine("프로그램이 종료되었습니다.");
                // finally에서 return 명령어 사용 불가능!
            }
        }
    }
}
