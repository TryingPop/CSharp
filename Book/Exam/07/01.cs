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
    internal class _07_01
    {
        static void Main1(string[] args)
        {
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();

            Console.Write("나이 입력 : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("키(cm) 입력 : ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("안녕하세요. ");
            Console.Write(name);
            Console.WriteLine("님!");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.Write("세 키는 ");
            Console.Write(height);
            Console.WriteLine("cm 입니다.");
        }
    }
}
