using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : if, else 그리고 else if
    교재 p147 ~ 150

    분기문은 프로그램의 흐름을 조건에 따라 여러 갈래로 나누는 흐름 제어 구문이다
    C#에서는 한 번에 단 하나의 조건만 평가할 수 있는 if문과 
    여러 개의 조건을 평가할 수 있는 switch문 두 가지의 분기문을 제공한다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _01_IfElse
    {

        static void Main1(string[] args)
        {

            Console.Write("숫자를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
                Console.WriteLine("음수");
            else if (number > 0)
                Console.WriteLine("양수");
            else
                Console.WriteLine("0");

            if (number % 2 == 0)
                Console.WriteLine("짝수");
            else
                Console.WriteLine("홀수");
        }
    }
}
