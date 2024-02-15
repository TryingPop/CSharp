using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 컬렉션 큐 실습하기
 * 
 * 큐(Queue)
 *  - 가장 기본적인 자료 구조
 *  - 먼저 입력된 데이터가 먼저 출력되는 선형구조(FIFO : 선입선출, First In First Out)
 *  - 다양한 알고리즘 및 함수 호출에 사용
 */

namespace Ch07
{
    internal class _2_Queue
    {
        static void Main1(string[] args)
        {
            // 리스트보다 성능이 부족
            // 리스트보다 단순한 자료형 구조
            Queue<string> que = new Queue<string>();

            que.Enqueue("김유신");
            que.Enqueue("김춘추");
            que.Enqueue("장보고");
            que.Enqueue("강감찬");
            que.Enqueue("이순신");

            while (que.Count > 0)
            {
                // 큐 원소 제거
                Console.WriteLine(que.Dequeue());
            }

            Console.WriteLine(que.Count);
        }
    }
}
