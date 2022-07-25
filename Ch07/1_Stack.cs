using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 컬렉션 스택 실습하기
 * 
 * 스택(Stack)
 *  - 가장 기본적인 자료구조
 *  - 한쪽 끝에서만 자료를 넣거나 빼는 선형구조(LIFO : 후입선출, Last In First Out)
 *  - 다양한 알고리즘 및 함수 호출에 사용
 */

namespace Ch07
{
    internal class _1_Stack
    {
        static void Main1(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // 5, 4, 3, 2, 1
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop()); 
            }
        }
    }
}

// 자료구조 : 자료를 효율적으로 처리하기 위한 데이터의 저장 형태 및 방법
// 컬렉션은 자료구조와 관련된 클래스 집합
// 컬렉션: ArrayList, List, HashSet, HashTable, Dictionary
// + stack(후입 선출 : Last In First Out(LIFO)) +queue(선입 선출(FIFO))
