using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.29
 * 내용 : 피보나치 연습문제
 */

namespace Exam._06
{
    internal class _06_08
    {
        static void Main8(string[] args)
        {
            LinkedList<string> lkList = new LinkedList<string>();

            lkList.AddFirst("김유신");
            lkList.AddFirst("김춘추");
            lkList.AddFirst("장보고");
            lkList.AddLast("강감찬");
            lkList.AddLast("이순신");
            lkList.AddLast("정약용");

            Console.WriteLine(string.Join(", ", lkList));

            LinkedListNode<string> findNode = lkList.Find("이순신");
            LinkedListNode<string> addNode1 = new LinkedListNode<string>("이성계");
            LinkedListNode<string> addNode2 = new LinkedListNode<string>("임꺽정");

            lkList.AddBefore(findNode, addNode1);
            lkList.AddAfter(findNode, addNode2);

            Console.WriteLine(string.Join(", ", lkList));
            Console.WriteLine();

            SortedList<int, string> stList = new SortedList<int, string>();

            stList.Add(101, "한국");
            stList.Add(104, "중국");
            stList.Add(106, "대만");
            stList.Add(103, "일본");
            stList.Add(105, "호주");
            stList.Add(102, "미국");

            Console.WriteLine(String.Join(", ", stList));

            for(int i = 0; i < stList.Count; i++)
            {
                Console.WriteLine($"stList K : {stList.Keys[i]}, V : {stList.Values[i]}");
            }


        }

    }
}
