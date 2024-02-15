using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 람다식 실습하기 교재 p500
 * 
 * 람다식(Lambda Expression)
 *  - 함수적 프로그래밍을 지원하기 위한 문법 식
 *  - 대리자를 조금 더 간편하게 사용하기 위한 식(익명함수)
 */

namespace Ch09
{
    internal class _2_람다식
    {
        static void Main2(string[] args)
        {
            // 람다식에서 ref, out은 사용할 수 없다
            // 반환이 있는 람다식(익명함수, Func 대리자)
            // 형태 : ( 매개변수 ) => { 함수 내용 return ?};
            // 대입연산자로 자주 이용
            Func<string> f1 = () => { return "f1 실행..."; };
            // 앞에껀 : 매개변수 맨뒤만 return 타입
            Func<int, string> f2 = (x) => { return $"f2 x : {x}"; };

            Func<int, int, string> f3 = (x, y) => { return $"f3 x : {x}, y : {y}"; };

            // 함수와 같다
            // 정의된 자리로 가서 실행
            string r1 = f1();
            string r2 = f2(2);
            string r3 = f3(8, 5);

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);

            // 반환이 없는 람다식(익명함수, Action 대리자)
            Action act1 = () => { Console.WriteLine("act1 실행..."); };
            Action<int> act2 = (x) => { Console.WriteLine($"act2 x : {x}"); };
            Action<int, int> act3 = (x, y) => { 
                Console.WriteLine($"act3 x : {x}, y : {y}"); 
            };

            act1();
            act2(2);
            act3(3, 5);

            // 람다식 활용
            // 메서드 자리에 lambda 식 이용
            List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            myList.ForEach((int n) =>
            {
                Console.Write($"{n} ");
            });
            Console.WriteLine();
            
            
        }
    }
}
