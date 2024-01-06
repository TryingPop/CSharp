using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 1. 6
이름 : 배성훈
내용 : 냅색문제
    문제번호 : 1450번
    
    Meet in the Middle 알고리즘을 이용한 풀이
    
    상황을 반으로 나눠서 푸는게 주된 아이디어다
    입력이 최대 30개 이므로 2^30 = 약 11억(10.7억에서 올림)
    그냥 탐색 하는 경우 시간 초과 뜬다!

    Meet in the Middle 아이디어의 핵심은 30개를 반으로 쪼개서 계산하는 것이다
    그래서 입력된 순서대로 15개씩 나누고, 부분합을 저장할 집합 left, right를 만든다
    부분합을 저장하는 방법은 DFS 탐색을 썼다

    그리고 정렬한 뒤 투 포인트 탐색을 시작한다

    정렬된 left, right에 대해 둘 중 하나를 기준으로 잡으면 된다
    필자는 left를 기준으로 잡았다 그리고 left의 인덱스를 1씩 이동시키며 
    left[i] + right[j] <= (가방의 무게)인 j의 개수들을 추가해나갔다
    right가 오름차순 정렬되어져 있으므로 left[i] + right[j] <= (가방의 무게)를 만족하는 j의 최대값을 찾으면
    j 이하의 인덱스에 대해서는 모두 만족하므로 최대값 찾는 문제로 바꼈다

    그래서 j를 찾는데 이진 탐색을 써도 되는데, 필자는 아직 이진 탐색을 한 방에 만드는게 힘들어 일단은 비효율적인 한칸씩 이동하는 방법을 썼다
    오늘 조금 더 해보고 이진 탐색으로 코드를 바꿔볼 예정이다!
*/

namespace BaekJoon._34
{
    internal class _34_05
    {

        static void Main5(string[] args)
        {

            // 입력
            long[] info = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // 초기 세팅
            GetArray((int)info[0], out long[] left, out long[] right);
            SetSubSum((int)info[0], nums, left, right);

            // 투 포인트 탐색
            int result = 0;
            int l = 0;
            int r = right.Length - 1;

            for (int i = 0; i < left.Length; i++)
            {

                if (left[i] > info[1]) break;

                long calc = left[i];
                // 이 부분 이분탐색으로 바꿔야 한다!
                for (int j = r; j >= 0; j--)
                {

                    if (right[j] + calc <= info[1])
                    {

                        r = j;
                        result += r + 1;
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }

        static void SetSubSum(int _len, int[] _nums, long[] _left, long[] _right)
        {

            // 값 채우기
            long sum = 0;
            int idx = 0;
            int mid = _len / 2;
            DFS(0, mid, ref sum, ref idx, _nums, _left);

            // idx는 초기화 필요!
            idx = 0;
            DFS(mid, _len - mid, ref sum, ref idx, _nums, _right);

            Array.Sort(_left);
            Array.Sort(_right);
        }

        /// <summary>
        /// 
        /// </summary>
        static void GetArray(int len, out long[] _left, out long[] _right)
        {

            
            int mid = len / 2;

            int leftNum = (int)Math.Pow(2, mid);
            int rightNum = (int)Math.Pow(2, len - mid);

            _left = new long[leftNum];
            _right = new long[rightNum];
        }


        static void DFS(int _start, int _len, ref long _sum, ref int _idx, int[] _nums ,long[] _result, int _cur = 0)
        {

            if (_cur == _len)
            {

                _result[_idx++] = _sum;
                return;
            }

            DFS(_start, _len, ref _sum, ref _idx, _nums, _result, _cur + 1);

            _sum += _nums[_cur + _start];
            DFS(_start, _len, ref _sum, ref _idx, _nums, _result, _cur + 1);
            _sum -= _nums[_cur + _start];
        }
    }
}
