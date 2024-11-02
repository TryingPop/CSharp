using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : Stack<T>
    교재 p 422

    앞과 같다.
*/

namespace Study._2024.Ch11_일반화.코드
{
    internal class _06_UsingGenericStack
    {

        static void Main6(string[] args)
        {

            Stack<int> stack = new Stack<int>();

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
