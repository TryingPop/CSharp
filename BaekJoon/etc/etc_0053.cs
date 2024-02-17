using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 2. 17
이름 : 배성훈
내용 : 중복 없는 수
    문제번호 : 11037번

    N 이상이 아닌 N 보다 큰 수로 찾는 거였다!
    해당 부분 때문에 의미없는 수정으로 많이 틀렸다;

    아이디어는 간단하다
    그냥 해당 수보다 큰 중복없는 수를 만들면 된다!
*/

namespace BaekJoon.etc
{
    internal class etc_0053
    {

        static void Main53(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            // 여기서 가능한 경우의 수 찾자!
            bool[] nums = new bool[10];

            // 수 기록
            int[] save = new int[10];
            while (true)
            {

                string str = sr.ReadLine();
                if (str == null || str == string.Empty) break;

                {
                    int calc = int.Parse(str) + 1;
                    if (calc != 1_000_000_000) str = calc.ToString();
                }

                for (int i = 1; i < 10; i++)
                {

                    nums[i] = false;
                    save[i] = 0;
                }

                nums[0] = true;

                int len = str.Length;

                int changePos = len + 1;
                for (int i = 1; i <= len; i++)
                {

                    int c = str[i - 1] - '0';
                    save[i] = c;

                    if (nums[c])
                    {

                        changePos = i;
                        break;
                    }

                    nums[c] = true;
                }

                while (changePos <= len && changePos > 0)
                {

                    bool findValue = false;
                    // 변화가 있다
                    // 해당 자리 조사
                    for (int i = save[changePos] + 1; i < 10; i++)
                    {

                        // 빈거 있으면 해당 수로 교체
                        if (!nums[i])
                        {

                            save[changePos] = i;
                            changePos++;
                            nums[i] = true;

                            if (changePos <= len)
                            {

                                for (int j = 1; j < 10; j++)
                                {

                                    if (!nums[j])
                                    {

                                        save[changePos++] = j;
                                        nums[j] = true;
                                    }

                                    if (changePos > len) break;
                                }
                            }

                            if (changePos > len) 
                            {

                                findValue = true;
                                break; 
                            }
                        }
                    }


                    if (!findValue)
                    {

                        save[changePos] = 0;
                        changePos--;
                        if (save[changePos] != 0) nums[save[changePos]] = false;
                    }
                }

                if (changePos == 0)
                {

                    if (len == 9) sw.WriteLine(0);
                    else
                    {

                        for (int i = 1; i <= len + 1; i++)
                        {

                            sw.Write(i);
                        }

                        sw.Write('\n');
                    }
                }
                else
                {

                    for (int i = 1; i <= len; i++)
                    {

                        sw.Write(save[i]);
                    }
                    sw.Write('\n');
                }


                sw.Flush();
            }

            sr.Close();
            sw.Close();
        }
    }

#if other
from sys import stdin
input = stdin.readline

def main():
    N = input().rstrip()
    n_len = len(N)
    
    if int(N) >= MAX:
        return 0
    
    if int(N) >= int(str(MAX)[:n_len]):
        return int(str(MIN)[:(n_len+1)])
    
    visited = [False] * 10
    answer = []

    def dfs(rank, flag):
        if rank == n_len:
            intanswer = 0
            for i in range(n_len):
                intanswer += answer[i]*(10**(n_len-1-i))

            if intanswer > int(N):
                return intanswer
                
            return 0

        for i in range(min(flag,int(N[rank])), 10):
            if i==0 or visited[i]:
                flag = 1
                continue
                
            visited[i] = True
            answer.append(i)
            
            temp = dfs(rank+1, flag)
            if temp > 0:
                return temp
                
            visited[i] = False
            answer.pop()
            flag = 1

        return 0

    x = dfs(0, 9)
    return x

MAX = 987654321
MIN = 123456789
while True:
    try:
        print(main())
    except:
        break

#elif other2
// 중복 없는 수
import sys
input = sys.stdin.read

def dfs(m):
    if len(s) == m:
        lst.append(conv(s))
        return 
    
    for i in num:
        if not i in s:
            s.append(i)
            dfs(m)
            s.pop()
    
def find(i):
    lo,hi = -1,n
    while lo+1 < hi:
        mid = (lo+hi)//2

        if lst[mid] > i:
            hi = mid
        else:
            lo = mid

    return lst[hi]

conv = lambda x:int(''.join(x))
num = '123456789'
inf = 987654321

lst = []
s = []
for i in range(1,10):
    dfs(i)

lst.sort()
n = len(lst)

d = list(map(int,input().split()))

for i in d:
    res = find(i) if i < inf else 0
    print(res)
#endif
}
