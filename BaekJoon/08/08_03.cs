using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.21
 * 내용 : 백준 8단계 3번 문제
 * 
 */

namespace BaekJoon._08
{
    internal class _08_03
    {
        static void Main3(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int num = int.Parse(Console.ReadLine());

            bool chk = true;
            if (num != 1)
            {
                while (chk)
                {
                    int n = num;
                    for (int i = 2; i < n; i++)
                    {
                        if ( i == ((int)Math.Sqrt(n)) + 1)
                        {
                            chk = false;
                            sb.AppendLine(num.ToString());
                            break;
                        }
                        if (num % i == 0)
                        {
                            num /= i;
                            sb.AppendLine(i.ToString());
                            break;
                        }
                    }
                }
            }
            
        }
    }
}
