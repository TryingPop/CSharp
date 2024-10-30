using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : switch 문
    교재 p 152 ~ 155

    정수와 문자열 형식 외에도 C# 7.0 부터는 switch 문에 데이터 형식을 조건으로 사용할 수 있게 되었다
    이전에는 정수만 사용 가능했다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _03_Switch
    {

        static void Main3(string[] args)
        {

            Console.Write("요일을 입력하세요.(일, 월, 화, 수, 목, 금, 토) : ");
            string day = Console.ReadLine();

            switch(day)
            {

                case "일":
                    Console.WriteLine("Sunday");
                    break;

                case "월":
                    Console.WriteLine("Monday");
                    break;

                case "화":
                    Console.WriteLine("Tuesday");
                    break;

                case "수":
                    Console.WriteLine("Wednesday");
                    break;

                case "목":
                    Console.WriteLine("Thursday");
                    break;

                case "금":
                    Console.WriteLine("Friday");
                    break;

                case "토":
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine($"{day}는(은) 요일이 아닙니다.");
                    break;
            }
        }
    }
}
