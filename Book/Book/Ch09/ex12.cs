using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 9-12
 * 
 * 인터페이스 구현
 */

namespace Book.Ch09
{
    internal class ex12
    {
        class TestClass : IBasic
        {
            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }

            public int TestProperty
            {
                get 
                { 
                    throw new NotImplementedException(); 
                }
                set 
                { 
                    throw new NotImplementedException(); 
                }
            }
        }
        static void Main12(string[] args)
        {

        }
    }
}
