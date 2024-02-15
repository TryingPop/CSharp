

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 11-10
 * 
 * Thread 클래스의 인스턴스 생성
 */

namespace Book.Ch11
{
    internal class ex10
    {
        static void Main10(string[] args)
        {
            Thread threadA = new Thread(TestMethod);
            Thread threadB = new Thread(delegate () { });

            Thread threadC = new Thread(() => 
            {
                
            });
        }

        public static void TestMethod()
        {

        }
    }
}
