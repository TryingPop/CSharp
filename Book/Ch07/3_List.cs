using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Ch07.Sub1;

/* 날짜 : 2022.07.25
 * 내용 : 컬렉션 리스트 실습하기 교재 p211
 * 
 * 리스트(List)
 *  - 배열과 유사한 선형 자료구조로 배열과 다르게 동적으로 데이터를 처리
 *  - ArrayList 일반화 시켜 더 나은 성능을 가진 List를 사용
 */

namespace Ch07
{
    // List는 배열과 유사한 동적 선형 자료 구조
    // 배열은 구조 길이가 결정되면 변경 불가능(정적 자료 구조)
    internal class _3_List
    {
        static void Main3(string[] args)
        {
            // ArrayList
            // ArrayList는 다른 타입도 허용가능

            // 생성 (System.Collections 모듈 필요)
            ArrayList arrList1 = new ArrayList();

            // 데이터 추가
            for (int i = 1; i <= 5; i++)
            {
                arrList1.Add(i);
            }

            // 데이터 삽입
            // args : index, value
            // 0 번부터 시작
            arrList1.Insert(1, 6);

            // 데이터 삭제
            // for문에 넣을때 주의
            // 바로 바로 삭제되기에 오류가 잦게 발생한다
            // 역순으로 제거하면 크게 이상없다
            // value 삭제
            arrList1.Remove(6);

            // index 삭제
            arrList1.RemoveAt(1);

            foreach (int n in arrList1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            // 다양한 타입의 데이터를 갖는 ArrayList
            // arraylist는 지양하는게 좋다
            ArrayList arrList2 = new ArrayList();

            arrList2.Add(1);
            arrList2.Add(1.23f);
            arrList2.Add(true);
            arrList2.Add('A');
            arrList2.Add("Apple");

            foreach (var e in arrList2)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.GetType());
                Console.WriteLine();
            }

            for (int i = 0; i < arrList2.Count; i++)
            {
                Console.Write(arrList2[i] + " ");
            }
            Console.WriteLine();

            // List
            // List는 다른 타입 허용 X 그래서 List가 성능이 더 좋다(Generic)

            // 생성
            List<int> list1 = new List<int>();

            // 데이터 추가
            for (int i = 1; i <= 5; i++)
            {
                list1.Add(i);
            }

            // 데이터 삽입
            list1.Insert(1, 6);

            // 데이터 삭제
            // value 삭제
            list1.Remove(4);

            // index 삭제
            list1.RemoveAt(1);

            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            List<string> list2 = new List<string>();

            list2.Add("서울");
            list2.Add("대전");
            list2.Add("대구");
            list2.Add("부산");
            list2.Add("광주");

            foreach (string city in list2)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // 객체 리스트
            List<Apple> list3 = new List<Apple>();

            list3.Add(new Apple("한국", 3000));
            list3.Add(new Apple("미국", 2000));
            list3.Add(new Apple("일본", 1000));

            Apple apple1 = list3[0];
            apple1.Show();

            list3[1].Show();
            list3[2].Show();
        }
    }
}
