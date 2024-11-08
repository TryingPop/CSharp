using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 8
이름 : 배성훈
내용 : 문 형식의 람다식
    교재 p 490 ~ 492

    람다식은 식(Expression) 형식을 하고 있다.
    문 형식의 람다 식(Statement Lambda)는 => 연산자의 오른편에 
    식 대신 { }로 둘러싸인 코드 블록이 위치한다.
*/

namespace Study._2024.Ch14_람다식.코드
{
    internal class _02_StatementLambda
    {

        delegate string Concatenate(string[] args);

        static void Main2(string[] args)
        {

            Concatenate concat =
                (arr) =>
                {

                    string result = "";
                    foreach (string s in arr)
                        result += s;

                    return result;
                };

            Console.WriteLine(concat(args));
        }
    }
}
