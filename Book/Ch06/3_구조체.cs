using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.20
 * 내용 : 구조체 실습하기 교재 p404
 * 
 * 구조체(Structure)
 *  - 간단하게 객체를 만들때 사용하는 구조형식
 *  - 클래스와 동일하지만 상속, 다형성 등 지원 안함
 */

namespace Ch06
{
    struct Point 
    {
        // 초기값 private
        public int x;
        public int y;

        // 생성자
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Add()
        {
            return x + y;
        }
    }


    internal class _3_구조체
    {

        static void Main3(string[] args)
        {
            // 클래스와 유사
            // 간단한 객체를 만들 떄 사용
            // 캡슐화, 상속은 지원 안한다

            // 스텍 할당제
            Point p1;

            p1.x = 1;
            p1.y = 2;

            Console.WriteLine("p1.Add() : {0}", p1.Add());

            Point p2 = new Point(2, 3);
            Console.WriteLine("p2.Add() : {0}", p2.Add());
        }
    }
}
