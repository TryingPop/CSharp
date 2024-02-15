using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 조건문 Switch 실습하기 교재 p127
 * 
 */

namespace Ch03
{
    internal class _2_Switch문
    {
        static void Main2(string[] args)
        {
            // 조건에 따라 코드를 나눈다
            /*
            switch (비교할 값)
            {
                case 값:
                    실행 코드
                    break;
                case 값:
                    실행 코드
                    break;
                default:
                    case 중에 만족하는게 없으면 실행코드
                    break;
            */

            Console.Write("숫자 입력 : ");
            string strNum = Console.ReadLine();

            // Ch02의 문자열 부분 참조
            int number = int.Parse(strNum);

            switch (number % 2)
            {
                case 0:
                    Console.WriteLine(strNum + " 짝수 입니다");
                    break;
                case 1:
                    Console.WriteLine(strNum + " 홀수 입니다");
                    break;
            }
            
            

        }
    }
}
