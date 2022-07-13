using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-68
 * 
 * 간단한 문자열 변환
 */

namespace Book.Ch02
{
    internal class ex68
    {
        static void Main68(string[] args)
        {
            int number = 52273;
            string outputA = number + "";
            Console.WriteLine("outputA : {0}", outputA);
            
            char character = 'a';
            // string output = character;
            // char 자료형 타입을 바로 string 으로 변환하려고 하면 오류가 생긴다
            string outputB = character + "";
            Console.WriteLine("outputB : {0}", outputB);
            Console.WriteLine("outputB : {0}", outputB.GetType());
        }
    }
}
