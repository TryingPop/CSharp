using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : switch 식
    교재 p 159 ~ 162

    switch 식을 사용하면 보다 좋은 코드를 작성할 수 있다
    default는 _로 대체하고 break는 ,로 대체된다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _06_SwitchExp
    {

        static void Main6(string[] args)
        {

            Console.WriteLine("점수를 입력하세요");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("재수강인가요? (y/n)");
            string line = Console.ReadLine().ToLower();
            bool repeated = line == "y" ? true : false;

            string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
            {

                90 when repeated == true => "B+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };

            Console.WriteLine($"학점 : {grade}");
        }
    }
}
