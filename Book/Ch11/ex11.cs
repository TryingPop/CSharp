

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 11-11
 * 
 * 스레드 실행
 */

namespace Book.Ch11
{
    internal class ex11
    {
        static void Main11(string[] args)
        {
            Thread threadA = new Thread(() =>
            {
                for(int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("A");
                }
            });

            Thread threadB = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("B");
                }
            });

            Thread threadC = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("C");
                }
            });

            threadA.Start();
            threadB.Start();
            threadC.Start();
        }

    }
}
