using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Ch07.Sub1;

/* 날짜 : 2022.07.25
 * 내용 : 컬렉션 딕셔너리 실습하기
 * 
 * 딕셔너리(Dictionary)
 *  - 키값(Key - Value) 쌍으로 이루어진 자료구조
 *  - Dictionary는 HashTable을 일반화 시켜 더 나은 성능을 제공
 *  - List와 더불어 가장 많이 사용하는 자료 구조
 */

namespace Ch07
{
    // index, insert가 없다
    // key값이 대신하기 때문에
    internal class _4_Dictionary
    {
        static void Main4(string[] args)
        {
            // HashTable

            // Table 생성
            Hashtable ht = new Hashtable();

            // 데이터 추가
            ht['A'] = "Apple";
            ht.Add('B', "Banana");
            ht.Add('C', null);

            ht.Remove('A');

            // 데이터 출력
            foreach (string value in ht.Values)
            {
                Console.WriteLine("ht : {0}", value);
            }
            Console.WriteLine();

            // Dictionary

            // Dictionary 생성
            Dictionary<char, string> dic = new Dictionary<char, string>();

            // 데이터 추가
            dic['A'] = "Apple";
            dic.Add('B', "Banana");
            dic.Add('C', "Cherry");

            dic.Remove('B');

            foreach (char c in dic.Keys)
            {
                Console.WriteLine("dic : {0}", dic[c]);
            }
            Console.WriteLine();

            // 딕셔너리 연습I
            Dictionary<int, string> people = new Dictionary<int, string>();

            people.Add(101, "김유신");
            people.Add(102, "김춘추");
            people.Add(103, "장보고");
            people.Add(104, "강감찬");
            people.Add(105, "이순신");

            foreach (int key in people.Keys)
            {
                Console.WriteLine($"Key : {key}\nValue : {people[key]}");
            }

            // 딕셔너리 연습II
            Dictionary<int, Apple> d1 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d2 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d3 = new Dictionary<int, Apple>();

            d1.Add(101, new Apple("한국", 3000));
            d1.Add(102, new Apple("미국", 2000));
            d1.Add(103, new Apple("일본", 1000));

            d2.Add(201, new Apple("중국", 500));
            d2.Add(202, new Apple("대만", 1000));
            d2.Add(203, new Apple("홍콩", 1500));

            d3.Add(301, new Apple("영국", 1500));
            d3.Add(302, new Apple("인도", 2500));
            d3.Add(303, new Apple("호주", 3500));

            /*
            foreach (Apple apple in d1.Values)
            {
                apple.Show();
            }
            */
            List<Dictionary<int, Apple>> apples = new List<Dictionary<int, Apple>>() { d1, d2, d3 };

            // 한국 사과 출력
            apples[0][101].Show();

            Dictionary<int, Apple> dicApple1 = apples[0];
            Apple apple1 = dicApple1[101];
            apple1.Show();

            // 미국 사과
            apples[0][102].Show();

            // 대만 사과
            apples[1][202].Show();

            // 인도 사과
            apples[2][302].Show();
        }
    }
}
