
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.02
 * 내용 : 피보나치 연습문제
 */

namespace Exam._07
{
    internal class _07_03
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("{0:N2}", 1234.5678);
            Console.WriteLine("{0:D8}", 1234);
            Console.WriteLine("{0:F3}", 1234.56);
            Console.WriteLine("{0, 8}", 1234);
            Console.WriteLine("{0, -8}", 1234);
            Console.WriteLine();

            string str1 = string.Format("{0:N2}", 1234.5678);
            string str2 = string.Format("{0:D8}", 1234);
            string str3 = string.Format("{0:F3}", 1234.56);

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine();

            Console.WriteLine("{0:#.##}", 1234.5678);
            Console.WriteLine("{0:#,#.##}", 1234.5678);
            Console.WriteLine("{0:000000.00}", 1234.5678);
            Console.WriteLine();

            for (int i = 1; i<=50; i++)
            {
                Console.Write("{0, 3}{1}", i, i%10 != 0? "":"\n");
                
            }
        }
    }
}

// 참고 사이트
// http://www.dreamy.pe.kr/zbxe/CodeClip/157656
