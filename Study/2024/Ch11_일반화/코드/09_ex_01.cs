using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : 연습문제 1
    교재 p 429

    다음 코드에서 문제를 찾고, 그 원인을 설명하세요.
    
    코드
        Queue queue = new Queue();
        queue.Enqueue(10);
        queue.Enqueue("한글");
        queue.Enqueue(3.14);

        Queue<int> queue2 = new Queue<int>();
        queue2.Enqueue(10);
        queue2.Enqueue("한글");
        queue2.Enqueue(3.14);

    제네릭 컬렉션인 Queue<int>는 int 자료형만 담을 수 있다.
    그런데 string 자료형인 "한글"이나 double 자료형인 3.14를 넣으려고 해서 컴파일에러가 뜰 것이다.
*/

namespace Study._2024.Ch11_일반화.코드
{
    internal class _09_ex_01
    {
    }
}
