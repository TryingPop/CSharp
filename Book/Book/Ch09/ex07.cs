using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 9-7
 * 
 * IDisposable 인터페이스의 메서드 생성
 */

namespace Book.Ch09
{
    internal class ex07
    {
        class Dummy : IDisposable
        {
            public void Dispose() 
            {
                throw new NotImplementedException();
            }
        }

        static void Main7(string[] args)
        {
        }
    }
}
