using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.28
 * 내용 : 피보나치 연습문제
 */

namespace Exam._05
{
    internal class _05_03
    {
        static void Main3(string[] args)
        {
            printList(createList());
        }

        public static void printList(List<int> scoreList)
        {
            int total = 0;
            int count = scoreList.Count;

            for (int i = 0; i < count; i++)
            {
                int score = scoreList[i];

                total += score;

                Console.Write(score);

                if (i == count - 1)
                {
                    Console.Write(" = ");
                }
                else
                {
                    Console.Write(" + ");
                }
                Console.WriteLine(total);
            }
        }

        public static List<int> createList()
        {
            List<int> scoreList = new List<int>();
            Random random = new Random();

            for (int i = 1; i <=10; i++)
            {
                int num = random.Next(41) + 60;
                scoreList.Add(num);
            }

            return scoreList;
        }
    }
}
