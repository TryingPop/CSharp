using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 3
이름 : 배성훈
내용 : Finally
    교재 p 441 ~ 446

    try 블록에서 코드를 실행하다가 예외가 던져지면 프로그램의 실행이 catch 절로 바로 뛰어넘어 온다.
    try 블록의 자원 해제 같은 중요한 코드를 미처 실행하지 못한다면 버그를 만드는 원인이 된다.
    C#에서는 예외를 처리할 때 자원 해제 같은 뒷 마무리를 실행할 수 있도록 finally 절을 try ~ catch 문과 함께 제공한다.
    try 절이 실행된다면 finally 절은 어떤 경우라도 실행된다.
    finally 절은 return을 해도 실행된다! 그리고 finally 절에서도 예외가 날 수 있다면 try ~ catch 절을 안에 이용하는게 좋다.
*/

namespace Study._2024.Ch12_예외.코드
{
    internal class _05_Finally
    {

        static int Divide(int divided, int divisor)
        {

            try
            {
                Console.WriteLine("Divide() 시작");
                return divided / divisor;
            }
            catch(DivideByZeroException e)
            {

                Console.WriteLine("Divide() 예외 발생");
                throw e;
            }
            finally
            {

                Console.WriteLine("Divide() 끝");
            }
        }

        static void Main5(string[] args)
        {

            try
            {

                Console.Write("제수를 입력하세요. : ");
                String temp = Console.ReadLine();
                int divided = Convert.ToInt32(temp);

                Console.Write("피제수를 입력하세요. : ");
                temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.WriteLine("{0}/{1} = {2}",
                    divided, divisor, Divide(divided, divisor));
            }
            catch (FormatException e)
            {

                Console.WriteLine("에러 : " + e.Message);
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine("에러 : " + e.Message);
            }
            finally
            {

                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
