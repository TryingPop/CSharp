using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.08.08
 * 내용 : KeyAvailable 메서드
 */

namespace Private
{
    internal class _15_KeyAvailable
    {
        static void Main15(string[] args)
        {
            /*
            ConsoleKeyInfo cki;


            do
            {
                Console.WriteLine("\nPress a key to display; press the 'x' key to quit.");

                // Your code could perform some useful task in the following loop. However,
                // for the sake of this example we'll merely pause for a quarter second.

                // 키 누를 때 동안 대기
                while (Console.KeyAvailable == false)
                {
                    Thread.Sleep(250); // Loop until input is entered.
                }
                cki = Console.ReadKey(true);
                Console.WriteLine("You pressed the '{0}' key.", cki.Key);
            } while (cki.Key != ConsoleKey.X);
            */

            variance v = new variance();
            Console.Write("키 입력 : ");
            v.character = char.Parse(Console.ReadLine());

            Task task = new Task(ReadKey, v);
            task.Start();

            task.Wait();
        }

        class variance
        {
            public char character;
        }

        // 수정하기
        public static void ReadKey(object? obj)
        {
            char out_Key = (obj as variance).character;

            ConsoleKeyInfo inputKey;

            do
            {
                Console.WriteLine("Press a Key!");

                while (Console.KeyAvailable == false) { }
                inputKey = Console.ReadKey(true);
                // 알파벳인 경우 대문자로 출력된다
                // 위쪽의 넘버인 경우 D0 ~ 9, 우측의 넘버 패드인 경우 NumberPad0 ~ 9 로 표현된다
                // Console.WriteLine(inputKey.Key.ToString());
            } while (inputKey.Key.ToString() != out_Key.ToString().ToUpper());
        }

    }
}

// 참고 사이트 
// https://docs.microsoft.com/ko-kr/dotnet/api/system.console.keyavailable?view=net-6.0

// 이후 아래 사이트도 한 번 확인!
// http://daplus.net/c-net-%EC%BD%98%EC%86%94-%EC%95%B1%EC%97%90%EC%84%9C-%ED%82%A4-%EB%88%84%EB%A6%84%EC%9D%84-%EB%93%A3%EC%8A%B5%EB%8B%88%EB%8B%A4/