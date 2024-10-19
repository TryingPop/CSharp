using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 9-15
 * 
 * 다중 상속과 다형성
 */

namespace Book.Ch09
{
    internal class ex15
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
            Child child = new Child();
            Parent childAsParent = new Child();
            IDisposable childAsIDisposable = new Child();
            IComparable childAsIComparable = new Child();
        }
    }
}
