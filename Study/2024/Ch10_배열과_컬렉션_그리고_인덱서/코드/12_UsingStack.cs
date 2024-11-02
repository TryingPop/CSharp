using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : Stack
    교재 p 386 ~ 387

    나중에 들어온 데이터부터 먼저 나간다.
    마찬가지로 들어오고 나가는 데이터가 object이다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _12_UsingStack
    {

        static void Main12(string[] args)
        {

            System.Collections.Stack stack = new System.Collections.Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
        }
    }
}
