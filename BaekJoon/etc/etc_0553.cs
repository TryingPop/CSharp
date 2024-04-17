using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. 17
이름 : 배성훈
내용 : 포스택
    문제번호 : 25556번

    그리디, 자료구조, 스택 문제다
    그리디하게 접근해서 해결했다

    스택 4개로 조건대로 정렬한다면 수를 담을 때, 
    적어도 자기보다 큰 수가 위에 담겨야 정렬이 된다
    작은 수가 있으면 조건대로 정렬이 불가능하다

    여기서 그리디하게 접근해서
    1번 스택을 4개 중 가장 큰값이 담기게하는 스택, 
    2번 스택을 4개 중 2번째로 큰 값이 담기게 하는 스택,
    ... 4번 스택까지 이렇게 역할을 부여했다

    그리고 해당 스택으로 오름차순 정렬이 가능한지 
    몇 가지 예시를 들어 확인했고 
        - 내림차순으로 자기보다 작은게 5개 있는 경우 4개 있는경우, 3개 있는 경우, 2개 있는경우, 1개 있는경우 0개 있는 경우만 했다
        (5개 이상은 불가능함을 예제로 미리 찾았기 때문!)

    이상없이 오름차순 정렬이 가능해
    해당 방법으로 제출하니 68ms에 이상없이 통과했다
*/

namespace BaekJoon.etc
{
    internal class etc_0553
    {

        static void Main553(string[] args)
        {

            string YES = "YES";
            string NO = "NO";
            StreamReader sr = new(Console.OpenStandardInput(), bufferSize: 65536 * 16);

            Solve();
            sr.Close();

            void Solve()
            {

                int n = ReadInt();

                int[] max = new int[4];
                bool ret = true;
                for (int i = 0; i < n; i++)
                {

                    int c = ReadInt();
                    ret = false;
                    for (int j = 0; j < 4; j++)
                    {

                        if (max[j] < c) 
                        { 
                            
                            max[j] = c;
                            ret = true;
                            break;
                        }
                    }

                    if (ret) continue;
                    break;
                }

                Console.WriteLine(ret ? YES : NO);
            }

            int ReadInt()
            {

                int c, ret = 0;
                while((c = sr.Read()) != -1 && c != '\n' && c != ' ')
                {

                    if (c == '\r') continue;
                    ret = ret * 10 + c - '0';
                }

                return ret;
            }
        }
    }
}
