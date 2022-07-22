using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.22
 * 내용 : 백준 10단계 5번 문제
 * 
 */

// 6000넘어가면 이상한값 나온다
// 알고리즘 다시 짜기!
namespace BaekJoon._10
{
    internal class _10_05
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            int head = -1;
            int tale = 0;
            int lenT = 0;
            bool flag = false;

            string result;
            for (int i = 0; i < num; i++)
            {
                FindNum(ref head, ref tale, ref lenT, ref flag);
            }
            if (lenT == 0)
            {
                if (head == 0)
                {
                    Console.WriteLine("666");
                }
                else
                {
                    Console.WriteLine(head + "666");
                }
            }
            else if (lenT == 1)
            {
                Console.WriteLine(head + "66" + tale);
            }
            else if (lenT == 2)
            {
                if (tale < 10)
                {
                    Console.WriteLine(head + "60" + tale);
                }
                else
                {
                    Console.WriteLine(head + "6" + tale);
                }
            }
            else if (lenT == 3)
            {
                if (tale < 10)
                {
                    Console.WriteLine(head + "600" + tale);
                }
                else if (tale < 100)
                {
                    Console.WriteLine(head + "60" + tale);
                }
                else
                {
                    Console.WriteLine(head + "6" + tale);
                }
            }
            else if (lenT == 4)
            {
                if (tale < 10)
                {
                    Console.WriteLine(head + "000" + tale);
                }
                else if (tale < 100)
                {
                    Console.WriteLine(head + "00" + tale);
                }
                else if (tale < 1000)
                {
                    Console.WriteLine(head + "0" + tale);
                }
                else
                {
                    Console.WriteLine(head + tale);
                }
            }
        }

        static void FindNum(ref int head, ref int tale, ref int lenT, ref bool flag)
        {
            if (flag)
            {
                if (tale < ((int)Math.Pow(10, lenT))-1)
                {
                    tale++;
                    return;
                }
                else
                {
                    flag = false;
                    tale = 0;
                    lenT = 0;
                    head++;
                    return;
                }
            }
            else
            {
                if (head % 10 != 5)
                {
                    head++;
                    return;
                }
                else
                {
                    head++;
                    flag = true;
                    lenT = 1;
                    if (head % 100 == 66)
                    {
                        lenT = 2;
                        if (head % 1000 == 666)
                        {
                            lenT = 3;
                        }
                    }
                    return;
                }
            }
        }
    }
}
