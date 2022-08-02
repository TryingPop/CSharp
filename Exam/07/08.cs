
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.02
 * 내용 : 피보나치 연습문제
 */

namespace Exam._07
{
    internal class _07_08
    {
        static void Main8(string[] args)
        {
            string name = "홍길동";
            int age = 27;

            string str1 = "안녕 " + name + ", 올해 " + age + "세 입니다.";
            Console.WriteLine(str1);

            string str2 = string.Format("안녕 {0}, 올해 {1}세 입니다.", name, age);
            Console.WriteLine(str2);

            string str3 = $"안녕 {name}, 올해 {age}세 입니다.";
            Console.WriteLine(str3);

            string str4 = string.Concat("안녕 ", name, ", 올해 ", age, "세 입니다.");
            Console.WriteLine(str4);

            string[] animals = { "Tiger", "Eagle", "Shark", "Lion", "Rabbit" };
            string result1 = string.Concat(animals);
            Console.WriteLine(result1);

            string result2 = string.Join("-", animals);
            Console.WriteLine(result2);
        }
    }
}
