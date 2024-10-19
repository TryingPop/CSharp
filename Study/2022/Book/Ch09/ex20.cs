using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 9-20
 * 
 * StreamWriter 클래스로 파일에 문자열 쓰기
 */

namespace Book.Ch09
{
    internal class ex20
    {
        static void Main20(string[] args)
        {
            // StreamWriter는 IDisposable을 상속 받아서 Dispose() 메서드를 호출하는데
            // using 구문은 내부에서 예외가 발생하여도 강제적으로 Dispose() 메서드를 호출한다
            using (StreamWriter writer = new StreamWriter(@"C:test\test.txt"))
            {
                writer.WriteLine("안녕하세요");
                writer.WriteLine("StreamWriter 클래스를 사용해");
                writer.WriteLine("글자를 여러 줄 입력해봅니다.");

                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine($"반복문 - {i}");
                }
            }

            Console.WriteLine(File.ReadAllText(@"C:test\test.txt"));
        }
    }
}
