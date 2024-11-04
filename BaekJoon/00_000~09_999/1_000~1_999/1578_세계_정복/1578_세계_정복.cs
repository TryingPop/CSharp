using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 4
이름 : 배성훈
내용 : 세계 정복
    문제번호 : 1578번

    매개변수 탐색 문제다.
    만약 A개의 그룹을 만들 수 있다면, B < A 인 그룹을 만들 수 있다.
    이는 A개의 그룹에서 1개씩 지워나가면 된다.
    그리고 특정 개수 G가 안되면 G + 1도 당연히 안된다.

    이는 특정값 이하는 되고 특정값 초과는 안되는 정렬된 집합으로 생각할 수 있다.
    이분 탐색을 이용할 수 있다

    이제 그룹을 채우는 방법이 중요한다.
    그룹을 지을 수 있는 최대 가능한 경우를 Ret라하면 
    각 나라에서는 많아야 Ret명 들어갈 수 있다.
    이를 이용해 Ret보다 작거나 같은 사람들을 뽑으면서 Ret개 그룹이 만들어지는지 확인해주면 된다.

    Ret를 찾는 부분을 매개변수 탐색을 이용하면 된다.    
*/

namespace BaekJoon.etc
{
    internal class etc_1093
    {

        static void Main1093(string[] args)
        {

            int n, k;
            int[] arr;

            Solve();
            void Solve()
            {

                Input();

                GetRet();
            }

            void GetRet()
            {

                long l = 0, r = 100_000_000_000;

                while (l <= r)
                {

                    long mid = (l + r) >> 1;

                    long ret = 0;
                    for (int i = 0; i < n; i++)
                    {

                        ret += Math.Min(arr[i], mid);
                    }

                    if (mid * k <= ret) l = mid + 1;
                    else r = mid - 1;
                }

                Console.Write(l - 1);
            }

            void Input()
            {

                StreamReader sr = new(Console.OpenStandardInput(), bufferSize: 65536);

                n = ReadInt();
                k = ReadInt();

                arr = new int[n];
                for (int i = 0; i < n; i++)
                {

                    arr[i] = ReadInt();
                }

                sr.Close();

                int ReadInt()
                {

                    int ret = 0;

                    while (TryReadInt()) { }
                    return ret;

                    bool TryReadInt()
                    {

                        int c = sr.Read();
                        if (c == '\r') c = sr.Read();
                        if (c == '\n' || c == ' ') return true;
                        ret = c - '0';

                        while((c = sr.Read()) != -1 && c != ' ' && c != '\n')
                        {

                            if (c == '\r') continue;
                            ret = ret * 10 + c - '0';
                        }

                        return false;
                    }
                }
            }
        }
    }

#if other
// #include<stdio.h>
typedef long long ll;
ll a[51],i,k,n,lo=1,mi,hi,s;
int main(){
    scanf("%lld%lld",&n,&k);
    for(i=0;i<n;++i)scanf("%lld",a+i);
    hi=n*1000000000LL+3;
    while(lo<hi){
        mi=(lo+hi)>>1;
        s=0;
        for(i=0;i<n;++i)s+=a[i]<mi?a[i]:mi;
        if(s<mi*k)hi=mi;
        else lo=mi+1;
    }
    printf("%lld",lo-1);
    return 0;
}
#endif
}
