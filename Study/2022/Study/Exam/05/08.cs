using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.28
 * 내용 : 피보나치 연습문제
 */

namespace Exam._05
{
    internal class _05_08
    {
        static void Main8(string[] args)
        {
            Random random = new Random();
            int answer = random.Next(1, 11);
            int input = 0;
            int count = 0;

            do
            {
                count++;
                Console.WriteLine("-------------------------");
                Console.WriteLine("answer의 값을 맞춰보세요.");
                Console.Write("1 ~ 10 사이의 값을 입력 : ");

                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input < 0)
                    {
                        throw new Exception("음수는 입력될 수 없습니다.");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("숫자가 아닙니다. 숫자를 입력하세요.");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                if (answer > input)
                {
                    Console.WriteLine("더 큰 수를 입력하세요.");
                }
                else if (answer < input)
                {
                    Console.WriteLine("더 작은 수를 입력하세요.");
                }
                else
                {
                    Console.WriteLine($"answer : {answer}");
                    Console.WriteLine("정답입니다.");
                    Console.WriteLine($"시도 횟수 : {count}회");
                } 
            } while (true);

            Console.WriteLine("프로그램이 정상 종료 되었습니다.");
        }

    }
}
