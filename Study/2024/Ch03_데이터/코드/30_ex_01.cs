using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 연습문제 1
    교재 p 112

    다음과 같이 사용자로부터 사각형의 너비와 높이를 입력받아 넓이를 계산하는 프로그램을 완성하세요.
    다음 코드 중 주석 부분을 바꾸면 됩니다.
    
    지문
        사각형의 너비를 입력하세요.
        30
        사각형의 높이를 입력하세요
        40
        사각형의 넓이는 : 1200
*/
namespace Study._2024.Ch03
{
    internal class _30_ex_01
    {

        static void Main30(string[] args)
        {

            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            int area = Convert.ToInt32(width) * Convert.ToInt32(height);
            Console.WriteLine(area);
        }
    }
}
