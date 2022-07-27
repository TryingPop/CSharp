using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 10-11
 * 
 * 강제로 던진 예외의 예외 처리
 */

namespace Book.Ch10
{
    internal class ex11
    {
        static void Main11(string[] args)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception exception)
            {
                Console.WriteLine("예외가 발생했습니다.");
            }
        }
    }
}
