using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.04
 * 내용 : 피보나치 연습문제
 */

namespace Exam._09
{
    internal class _09_04
    {
        static void Main4(string[] args)
        {
            int[] values = { 3, 5, 2, 7, 1 };
            PrintArray(values);

            for (int i = 4; i >0; i--)
            {
                for (int j=0; j<i; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        int temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
                PrintArray(values);
            }
        }

        public static void PrintArray(int[] array) 
        {
            for (int tmp = 0; tmp < array.Length; tmp++)
            {
                Console.Write("{0}{1}", array[tmp], (tmp == array.Length - 1)? "\n":"\t");
            }
        }

    }
}
