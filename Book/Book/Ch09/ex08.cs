using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 9-8
 * 
 * Dispose() 메서드 구현 및 호출
 */

namespace Book.Ch09
{
    internal class ex08
    {
        class Dummy : IDisposable
        {
            public void Dispose() 
            {
                Console.WriteLine("Dispose() 메서드를 호출합니다.");
            }
        }

        static void Main8(string[] args)
        {
            Dummy dummy = new Dummy();
            dummy.Dispose();
        }
    }
}
