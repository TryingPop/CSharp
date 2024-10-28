using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : switch 문
    교재 p 158 ~ 159

    when 키워드를 이용해 추가적인 조건 검사를 할 수 있다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _05_Switch3
    {

        static void Main5(string[] args)
        {

            object obj = null;

            string s = Console.ReadLine();
            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            switch(obj)
            {

                case int i:
                    Console.WriteLine($"{i}는 int 형식입니다.");
                    break;

                case float f when f >= 0:
                    Console.WriteLine($"{f}는 양의 float 형식입니다.");
                    break;

                case float f:
                    Console.WriteLine($"{f}는 음의 float 형식입니다.");
                    break;

                default:
                    Console.WriteLine($"{obj}은(는) 모르는 형식입니다.");
                    break;
            }
        }
    }
}
