using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 12. 13
이름 : 배성훈
내용 : K번째 수
    문제번호 : 1300번

    현재 오답 코드이다!
    
*/

namespace BaekJoon._28
{
    internal class _28_05
    {

        static void Main(string[] args)
        {

            // 문제 입력
            int size = int.Parse(Console.ReadLine());
            int idx = int.Parse(Console.ReadLine());

            long start = 1;
            // 10^ 10 
            long end = size * size;
            if (end > 1_000_000_000) end = 1_000_000_000;

            long mid = 0;
            while (start < end)
            {

                // 여기서는 가장 작은값을 찾는다!
                mid = (start + end) / 2;
                long cnt = 0;

                // 자기보다 작은 값 찾기
                for (int i = 1; i <= size; i++)
                {

                    long chk = mid / i;
                    if (chk > size) chk = size;
                    cnt += chk;
                }

                if (cnt >= idx) 
                { 
                    
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }

            Console.WriteLine(end);
        }
    }
}
