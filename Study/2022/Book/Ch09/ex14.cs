using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 9-14
 * 
 * 다중 상속
 */

namespace Book.Ch09
{
    internal class ex14
    {
        class Parent { }

        class Child : Parent, IDisposable, IComparable
        {
            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

        static void Main14(string[] args)
        {

        }
    }
}
