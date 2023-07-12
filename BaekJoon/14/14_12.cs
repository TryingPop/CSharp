using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 12
이름 : 배성훈
내용 : 가장 긴 증가하는 부분 수열
    문제번호 : 11053번
*/

namespace BaekJoon._14
{
    internal class _14_12
    {

        static void Main12(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), item => int.Parse(item));

            /*
            // 시행 횟수가 수의 범위 보다 작을 때 좋은 방법
            // 그리고 앞번에 길이도 기록되어져 있다
            int[] lens = new int[length];           // 인덱스 i는 0번부터 i번까지 nums의 원소를 나열한 수열이라 해석하면 된다
                                                    // 값은 nums[i]를 마지막으로 포함하는 증가하는 부분 수열 중 길이가 가장 긴 값을 의미한다
                                                    // 여기서 주의할껀 nums[2] == nums[33] == 4, 이외의 i에 대해 nums[i] != 4
                                                    // lens[2]가 숫자 4를 가장 큰 값으로 갖는 증가하는 부분수열 중 가장 큰 길이라 할 수없다
                                                    // lens[2]와 lens[33] 중에 큰 값이 4를 가장 큰 값으로 갖는 증가하는 부분수열 중 가장 큰 길이가 될 것이다

            for (int i = 0; i < length; i++)
            {

                int len = 0;                        // 변수 세팅

                // 이전 항목 확인
                for (int j = 0; j < i; j++)
                {
                    
                    // nums[i]를 포함하는 증가하는 부분수열을 찾는게 목표이다
                    // nums[i] 값보다 작은 값에 대해서
                    // 증가하는 부분수열을 가장 긴 것을 찾는다
                    if (nums[i] > nums[j])
                    {

                        if (len < lens[j])
                        {
                            
                            // 가장 긴 것 확인
                            len = lens[j];
                        }
                    }
                }
                // 앞에서 끝값이 nums[i]보다 작은 가장 긴 증가하는 부분수열을 찾았으므로 
                // 뒤에 nums[i]를 이어 붙인다
                // 그러면 nums[i]를 포함하는 가장 긴 증가하는 부분수열이 된다
                lens[i] = len + 1;
            }

            int result = lens.Max();
            Console.WriteLine(result);
            */

            // 입력받은 수의 범위
            int[] lens = new int[1001];         // 인덱스 i는 증가하는 부분수열에서 가장 큰 값이 i이다
                                                // 값은 증가하는 부분수열 중 길이가 가장 큰 길이이다

            for (int i = 0; i < length; i++)
            {

                // 입력받는 수의 범위가 시행횟수보다 작은 경우 사용
                // 전체 수가 주어졌을 때 해당 수를 가장 큰 값으로 가지는 증가하는 부분수열의 길이를 찾는다
                // n이 무수히 커질 때 시간 복잡도가 n에 가므로 앞의 방법보다 빠르다고 볼 수있다
                int len = 0;

                // nums[i]보다 작은 값이 가장 큰 값인 증가하는 부분수열을 찾자
                // 그리고 이중 가장 길이가 가장 긴 것을 찾자
                for (int j = 1; j < nums[i]; j++)
                {

                    if (len < lens[j])
                    {

                        len = lens[j];
                    }
                }

                // k, k + 3이 nums[k] = nums[k+3]일 때, lens의 길이는 갱신 될 수있다
                // lens[nums[i]] = len + 1 >= nums[i] ? len + 1 : nums[i];       
                // 식을 위처럼 세워야하나 생각할 수있지만 lens[j]의 입력 방법(논리)에 따라 false인 경우는 나올 수가 없다
                lens[nums[i]] = len + 1;      
            }

            int result = lens.Max();
            Console.WriteLine(result);
        }
    }
}
