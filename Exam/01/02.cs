using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 입출력 연습문제
 */

namespace Exam._01
{
    internal class _01_02
    {
        static void Main2(string[] args)
        {
            int year;
            int birth;
            string name;

            Console.Write("올해 년도 입력 : ");
            year = int.Parse(Console.ReadLine());

            Console.Write("태어난 년도 입력 : ");
            birth = int.Parse(Console.ReadLine());
            // Convert.ToInt32(바꿀 것);
            // 대체 가능

            Console.Write("이름 입력 : ");
            name = Console.ReadLine();

            int age = year - birth;

            Console.WriteLine($"{name}님 안녕하세요.");
            Console.WriteLine($"당신의 나이는 만 {age}세 입니다.");
            // Console.WriteLine($"{name}님 안녕하세요. \n당신의 나이는 만 {age}세 입니다.");
            // 한 줄로 표현 가능

        }




    }
}
