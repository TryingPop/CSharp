using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.20
 * 내용 : 백준 7단계 8번 문제
 * 
 */

namespace BaekJoon._07
{
    internal class _07_08
    {
        static void Main8(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(" ");

            int len1 = inputs[0].Length;
            int len2 = inputs[1].Length;

            int len = len1;

            if (len1 < len2)
            {
                len = len2;
            }

            int[] num1 = new int[1 + (len / 7)];
            int[] num2 = new int[num1.Length];
            int[] resultarr = new int[num1.Length];

            int arg1 = 0;
            int arg2 = 0;


            // num1 과 num2 각각을 7자리씩 자르는 과정
            for (int i = 0; i < 1 + (len1 / 7); i++)
            {
                arg1 = len1 - (7 * (i + 1));
                arg2 = 7;
                if (arg1 < 0)
                {
                    if (arg1 != -7)
                    {
                        arg2 += arg1;
                        arg1 = 0;
                    }
                    else
                    {
                        continue;
                    }
                }
                num1[i] = int.Parse(inputs[0].Substring(arg1, arg2));
            }

            for (int i = 0; i < 1 + (len2 / 7); i++)
            {
                arg1 = len2 - (7 * (i + 1));
                arg2 = 7;
                if (arg1 < 0)
                {
                    if (arg1 != -7)
                    {
                        arg2 += arg1;
                        arg1 = 0;
                    }
                    else
                    {
                        continue;
                    }
                }
                num2[i] = int.Parse(inputs[1].Substring(arg1, arg2));
            }

            // 같은 자리끼리 합하는 과정 7자리로 잘랐으므로 
            // 8자리가 되면 앞자리를 제거하고 다음 항에 +1을 시킨다
            for (int i = 0; i < num1.Length; i++)
            {
                resultarr[i] += num1[i] + num2[i];
                if ((i <= num1.Length - 2) && (resultarr[i] >= 10000000))
                {
                    resultarr[i] -= 10000000;
                    resultarr[i + 1] += 1;
                }
            }

            bool output = false;

            for (int i = resultarr.Length - 1; i >= 0; i--)
            {
                if (resultarr[i] == 0)
                {
                    continue;
                }
                if (output)
                {
                    Console.Write("{0:0000000}", resultarr[i]);
                }
                else
                {
                    Console.Write(resultarr[i]);
                    output = true;
                }
            }
            Console.WriteLine();
        }
    }
}

/*

            Console.WriteLine("num1");
            foreach (int num in num1)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("num2");
            foreach (int num in num2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("ADD");
            foreach (int num in resultarr)
            {
                Console.WriteLine(num);
            }
*/
