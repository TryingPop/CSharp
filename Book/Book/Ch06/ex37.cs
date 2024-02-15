using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 6-37
 * 
 * 메모화
 */

namespace Book.Ch06
{
    internal class ex37
    {
        class Fibonacci
        {
            private static Dictionary<int, long> memo = new Dictionary<int, long>();
           
            public static long Get(int i)
            {
                if (i < 0)
                {
                    return 0;
                }
                else if (i == 1)
                {
                    return 1;
                }

                if (Fibonacci.memo.ContainsKey(i))
                {
                    return Fibonacci.memo[i];
                }
                else
                {
                    long value = Get(i - 2) + Get(i - 1);
                    Fibonacci.memo[i] = value;
                    return value;
                }

            }
        }

        static void Main37(string[] args)
        {
            Console.WriteLine(Fibonacci.Get(40));
            Console.WriteLine(Fibonacci.Get(100));
        }
    }
}