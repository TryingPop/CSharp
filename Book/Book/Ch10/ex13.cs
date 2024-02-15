
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 10-13
 * 
 * 사용자 정의 예제
 */

namespace Book.Ch10
{
    internal class ex13
    {
        class CustomException : Exception
        {
            public CustomException(string message) : base(message) 
            {
                
            }
        }

        static void Main13(string[] args)
        {
            try
            {
                throw new CustomException("사용자 정의 예외");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
