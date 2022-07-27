using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 9-13
 * 
 * 인터페이스 다형성
 */

namespace Book.Ch09
{
    internal class ex13
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
        static void Main13(string[] args)
        {
            IBasic basic = new TestClass();
        }
    }
}
