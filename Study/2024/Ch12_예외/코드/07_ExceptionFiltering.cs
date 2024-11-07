using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 7
이름 : 배성훈
내용 : 예외 필터하기
    교재 p 449 ~ 

    C# 6.0부터는 catch 절이 받아들일 예외 객체에 제약 사항을 명시해서 
    해당 조건을 만족하는 예외 객체에 대해서만 예외 처리 코드를 실행할 수 있도록 예외 필터(Exception Filter)가 도입되었다.

    예외에 필터를 만드는 데는 catch() 절 뒤에 when 키워드를 이용해서 제약 조건을 기술하면 된다.
*/

namespace Study._2024.Ch12_예외.코드
{
    internal class _07_ExceptionFiltering
    {

        class FilterableException : Exception
        {

            public int ErrorNo { get; set; }
        }

        static void Main7(string[] args)
        {

            Console.WriteLine("Enter Number Between 0 ~ 10");
            string input = Console.ReadLine();

            try
            {

                int num = Int32.Parse(input);

                if (num < 0 || num > 10)
                    throw new FilterableException() { ErrorNo = num };
                else
                    Console.WriteLine($"Output : {num}");
            }
            catch (FilterableException e) when (e.ErrorNo < 0)
            {

                Console.WriteLine("Negative input is not allowed.");
            }
            catch(FilterableException e) when (e.ErrorNo > 10)
            {

                Console.WriteLine("Too big number is not allowed.");
            }
        }
    }
}
