using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 7
이름 : 배성훈
내용 : 사용자 정의 예외 클래스 만들기
    교재 p 446 ~ 449

    C#의 모든 예외 객체는 System.Exception 클래스로부터 파생되어야 한다.
    이에 의거해 Exception 클래스를 상속하기만 하면 새로운 예외 클래스를 만들 수 있다.
    특별한 데이터를 담아서 예외 처리 루틴에 추가 정보를 제공하고 싶거나 
    예외 상황을 더 잘 설명하고 싶을 때는 사용자 정의 예외 클래스가 필요하다.
*/

namespace Study._2024.Ch12_예외.코드
{
    internal class _06_MyException
    {

        class InvalidArgumentException : Exception
        {

            public InvalidArgumentException() { }

            public InvalidArgumentException(string message) : base(message) { }

            public object Argument
            {

                get;
                set;
            }

            public string Range
            {

                get;
                set;
            }
        }

        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {

            uint[] args = new uint[] { alpha, red, green, blue };

            foreach (uint arg in args)
            {

                if (arg > 255)
                    throw new InvalidArgumentException() { Argument = arg, Range = "0 ~ 255" };
            }

            return (alpha << 24 & 0xFF000000) |
                (red << 16 & 0x00FF0000) |
                (green << 8 & 0x0000FF00) |
                (blue & 0x000000FF);
        }

        static void Main6(string[] args)
        {

            try
            {

                Console.WriteLine("0x{0:X}", MergeARGB(255, 111, 111, 111));    // 0xFF6F6F6F
                Console.WriteLine("0x{0:X}", MergeARGB(1, 65, 182, 128));       // 0x141B680
                Console.WriteLine("0x{0:X}", MergeARGB(0, 255, 255, 300));      // throw Exception
            }
            catch(InvalidArgumentException e)
            {

                // Exception of type 'Study._2024.Ch12_예외.코드._06_MyException+InvalidArgumentException' was thrown.
                Console.WriteLine(e.Message);
                Console.WriteLine($"Argument:{e.Argument}, Range:{e.Range}");   // Argument:300, Range:0 ~ 255
            }
        }
    }
}
