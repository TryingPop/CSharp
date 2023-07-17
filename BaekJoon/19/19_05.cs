using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 17
이름 : 배성훈
내용 : 스택 수열
    문제번호 : 1874번
*/

namespace BaekJoon._19
{
    internal class _19_05
    {

        static void Main5(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            int len = int.Parse(Console.ReadLine());

            Stack<int> stk = new Stack<int>(len);
            Queue<int> que = new Queue<int>(len);

            for (int i = 1; i <= len; i++)
            {

                que.Enqueue(i);
            }

            int chk = 0;

            for (int i = 0; i < len; i++)
            {

                int num = int.Parse(Console.ReadLine());

                if (chk < num)
                {

                    while (true)
                    {

                        int n = que.Dequeue();
                        stk.Push(n);
                        sb.AppendLine("+");

                        if (n == num)
                        {

                            break;
                        }
                    }

                    sb.AppendLine("-");
                    stk.Pop();
                    chk = num;
                }
                else if (chk > num)
                {

                    if (stk.Pop() == num)
                    {

                        sb.AppendLine("-");

                    }
                    else
                    {

                        sb.Clear();
                        sb.AppendLine("NO");
                        break;
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}
