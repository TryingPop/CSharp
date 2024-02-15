using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 10-4
 * 
 * 고급 예외 처리
 */

namespace Book.Ch10
{
    internal class ex04
    {
        static void Main4(string[] args)
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
            }
            finally
            {
                Console.WriteLine("프로그램이 종료되었습니다.");
            }
        }
    }
}
