using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 9-9
 * 
 * using 키워드와 IDisposable 인터페이스
 */

namespace Book.Ch09
{
    internal class ex09
    {
        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dispose() 메서드를 호출합니다.");
            }
        }

        static void Main9(string[] args)
        {
            // using을 사용하면 따로 호출하지 않아도 Dispose() 메서드가 호출된다
            using (Dummy dummy = new Dummy()) 
            {
                
            }
        }
    }
}
